import { ChangeDetectionStrategy, Component, OnDestroy, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatDividerModule } from '@angular/material/divider';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { BaselistComponent } from '../baselist/baselist.component';
import { ItemsTmplDirective } from '../items-tmpl.directive';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { TranslateModule } from '@ngx-translate/core';
import { BaseList } from '../baselist/baseList';
import { filter, Observable, switchMap, Subject, tap, map, take, takeUntil } from 'rxjs';
import { PaginationFilterRequest } from '../entities/paginationFilterRequest';
import { CreateInternship } from '../entities/createInternship';
import { InternshipDetailItem } from '../entities/internshipDetailItem';
import { InternshipService } from '../services/internship.service';
import { FilterType } from '../enums/filterType';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';
import { InternshipItem } from '../entities/internshipItem';
import { Router } from '@angular/router';
import { DeletePopupComponent } from '../delete-popup/delete-popup.component';

@Component({
  selector: 'intern-rapp-intern-ship-list',
  standalone: true,
  imports: [
    CommonModule,
    MatDividerModule,
    MatIconModule,
    MatListModule,
    BaselistComponent,
    TranslateModule,
    ItemsTmplDirective,
    ReactiveFormsModule,
    HttpClientModule,
    MatDialogModule,
  ],
  templateUrl: './intern-ship-list.component.html',
  styleUrls: ['./intern-ship-list.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class InternShipListComponent
  extends BaseList<InternshipItem>
  implements OnInit, OnDestroy
{
  public deleteSubject = new Subject<number>();
  public addSubject = new Subject<CreateInternship | undefined>();
  public updateSubject = new Subject<InternshipDetailItem>();
  private destroySubj$ = new Subject<void>();
  constructor(
    private internshipService: InternshipService,
    private router: Router,
    public dialog: MatDialog
  ) {
    super();
  }

  private popUpConfig = {
    width: '400px',
    closeOnNavigation: true,
    disableClose: false,
    hasBackdrop: true,
    position: { top: '250px', right: '500px' },
  };
  ngOnDestroy(): void {
    this.destroySubj$.next();
    this.destroySubj$.complete();
  }
  public addInternship() {
    this.router.navigateByUrl('internships/create');
  }
  public updateInternship(id: unknown) {
    this.internshipService
      .getInternshipById(id as number)
      .pipe(
        tap((data) => {
          this.internshipService.entityTobeUpdated = data;

          this.router.navigateByUrl('internships/create');
        }),
        take(1),
        takeUntil(this.destroySubj$)
      )
      .subscribe();
  }
  private configureDelete$() {
    return this.deleteSubject.pipe(
      switchMap((id) => {
        const dialogRef = this.dialog.open(
          DeletePopupComponent,
          this.popUpConfig
        );
        dialogRef.componentInstance.title = 'internship';
        return dialogRef
          .afterClosed()
          .pipe(map((confirm) => (confirm ? id : undefined)));
      }),
      filter((id) => !!id), //undefined checken
      switchMap((id) => this.internshipService.deleteInternship(id ?? 0))
    );
  }
  getGridItems$(
    paginationFilterRequest: PaginationFilterRequest
  ): Observable<ResourceItemPagingResponse<InternshipItem>> {
    return this.internshipService.filterAndPaginateLanguages(
      paginationFilterRequest
    );
  }
  ngOnInit(): void {
    this.filters = [
      {
        label: 'languageNameLabel',
        name: 'filterValue',
        type: FilterType.Text,
        observable: undefined,
      },
    ];

    this.configureItems([this.configureDelete$()]);
  }

  filterUpdating(filter: {}) {
    let filterString = '';
    const record = filter as Record<string, never>;
    this.filters?.forEach((x) => {
      filterString += `unit:${record[x.name]},`;
    });
    filterString = filterString.slice(0, filterString.length - 1);
    this.filterUpdated(filterString);
  }
  delete(id: number) {
    this.deleteSubject.next(id);
  }
}
