import {
  ChangeDetectionStrategy,
  Component,
  OnDestroy,
  OnInit,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormGroup,
  ReactiveFormsModule,
  FormControl,
  Validators,
  FormArray,
  AbstractControl,
} from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { TranslateModule } from '@ngx-translate/core';
import { Subject, Observable, switchMap, tap, of } from 'rxjs';
import { DepartmentService } from '../services/department.service';
import {
  MatAutocompleteModule,
} from '@angular/material/autocomplete';
import { DepartementItemWithMinimalData } from '../entities/depItemWithMinimalData';
import {
  filter,
  map,
  shareReplay,
  startWith,
  take,
  takeUntil,
} from 'rxjs/operators';
import { TrainingType } from '../enums/trainingType';
import { MatTabsModule } from '@angular/material/tabs';
import { LanguageItem } from '../entities/languageItem';
import { LanguageService } from '../services/language.service';
import {
  buildFormGroupForTranslations,
  convertFormsArrayToObjectForNewInternship,
  convertFormsArrayToObjectForUpdatedInternship,
} from '../translation-add-form/formGroupBuilder';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { LanguagePopupChoiceComponent } from '../language-popup-choice/language-popup-choice.component';
import { TranslationAddFormComponent } from '../translation-add-form/translation-add-form.component';
import { LocationItem } from '../entities/locationItem';
import { LocationService } from '../services/location.service';
import { CreateInternship } from '../entities/createInternship';
import { InternshipService } from '../services/internship.service';
import { Router } from '@angular/router';
import { InternshipTranslationUpdateDto } from '../entities/internshipTranslationUpdateDto';
import { InternshipUpdateDto } from '../entities/internshipUpdateDto';
@Component({
  selector: 'intern-rapp-internship-add',
  standalone: true,
  imports: [
    CommonModule,
    ReactiveFormsModule,
    MatInputModule,
    MatAutocompleteModule,
    MatDialogModule,
    TranslationAddFormComponent,
    MatSelectModule,
    TranslateModule,
    MatAutocompleteModule,
    MatTabsModule,
    MatIconModule,
    MatButtonModule,
  ],
  templateUrl: './internship-add.component.html',
  styleUrls: ['./internship-add.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class InternshipAddComponent implements OnInit, OnDestroy {
  public availableTrainingTypes = Object.values(TrainingType).slice(
    0,
    Object.values(TrainingType).length / 2
  ) as [];
  public addInternshipForm: FormGroup | undefined;
  public trainingType = TrainingType;
  constructor(
    private unitService: DepartmentService,
    private languageService: LanguageService,
    private dialog: MatDialog,
    private locationService: LocationService,
    private internShipService: InternshipService,
    private router: Router
  ) {}

  public unitObs$: Observable<DepartementItemWithMinimalData[]> | undefined;
  public locationObs$: Observable<LocationItem[]> | undefined;
  private languageObs$: Observable<LanguageItem[]> | undefined;
  private destrojSubj$ = new Subject();
  private popUpConfig = {
    width: '400px',
    closeOnNavigation: true,
    disableClose: false,
    hasBackdrop: true,
    position: { top: '250px', right: '630px' },
  };
  ngOnDestroy(): void {
    this.destrojSubj$.next(undefined);
    this.destrojSubj$.complete();
  }

  ngOnInit(): void {
    this.addInternshipForm = new FormGroup({
      schoolYear: new FormControl(
        this.internShipService.entityTobeUpdated?.schoolYear ??
          this.availableDates()[1],
        [Validators.required]
      ),
      unitId: new FormControl(
        this.internShipService.entityTobeUpdated?.unitId ?? '',
        [Validators.required]
      ),
      internshipId: new FormControl(
        this.internShipService.entityTobeUpdated?.internShipId ?? 0
      ),
      maxStudents: new FormControl(
        this.internShipService.entityTobeUpdated?.maxCountOfStudents ?? 0,
        [Validators.required, Validators.pattern('^[0-9]*$')]
      ),
      currentCountOfStudents: new FormControl(
        this.internShipService.entityTobeUpdated?.currentCountOfStudents ?? 0,
        [Validators.required, Validators.pattern('^[0-9]*$')]
      ),
      trainingType: new FormControl(
        this.internShipService.entityTobeUpdated?.trainingType ?? 0,
        [Validators.required]
      ),
      translateTabs: new FormArray([]),
      locations: new FormControl(
        this.internShipService.entityTobeUpdated?.locations ?? '',
        [Validators.required]
      ),
    });
    this.languageObs$ = this.languageService
      .filterAndPaginateLanguages({
        filterString: '',
        pageIndex: 1,
        pageSize: 100,
      })
      .pipe(
        shareReplay(1),
        map((data) => data.items)
      );
    this.locationObs$ = this.locationService
      .filterAndPaginateLocations$({
        filterString: '',
        pageIndex: 1,
        pageSize: 1000,
      })
      .pipe(map((data) => data.items));
    this.unitObs$ = this.addInternshipForm?.controls[
      'unitId'
    ].valueChanges.pipe(
      startWith(''),
      switchMap((data) => {
        return this.unitService.filterAndPaginateDepartmentsWithMinimalData({
          pageIndex: 1,
          filterString: 'unitName:' + data?.toString() ?? '',
          pageSize: 100,
        });
      }),
      map((data) => data.items)
    );
    this.internShipService.entityTobeUpdated?.versions.forEach(
      (x: InternshipTranslationUpdateDto) => {
        const controls = (
          this.addInternshipForm?.controls['translateTabs'] as FormArray
        ).controls;
        controls.push(
          buildFormGroupForTranslations(
            x,
            x.language.id,
            x.language.name ?? undefined
          )
        );
      }
    );
  }

  compareTrainingType(o1: any, o2: any) {
    return Number(o1) === o2;
  }
  availableDates() {
    const availableDates = [];
    const year = new Date().getFullYear();
    const previousYear = year - 1;
    for (let i = 0; i < 20; i++) {
      availableDates[i] = `${previousYear - i}-${year - i}`;
    }
    return availableDates;
  }

  public get tabsArrayLength() {
    return (this.addInternshipForm?.controls['translateTabs'] as FormArray)
      .length;
  }
  public get tabs() {
    return (this.addInternshipForm?.controls['translateTabs'] as FormArray)
      .controls;
  }
  public get tabIsInvalid() {
    let isInvalid = false;
    (
      this.addInternshipForm?.controls['translateTabs'] as FormArray
    ).controls.forEach((x) => {
      if (x.invalid) {
        isInvalid = true;
      }
    });
    return isInvalid;
  }

  addLanguage() {
    this.languageObs$
      ?.pipe(
        map((data) => {
          const itemsTobeReturned: LanguageItem[] = [];
          for (let i = 0; i < data.length; i++) {
            let isValid = true;
            for (let j = 0; j < this.tabs.length; j++) {
              if (this.tabs[j].getRawValue().languageId === data[i].id) {
                isValid = false;
                break;
              }
            }
            if (isValid) itemsTobeReturned.push(data[i]);
          }
          return itemsTobeReturned;
        }),
        switchMap((data) => {
          const dialogRef = this.dialog.open(
            LanguagePopupChoiceComponent,
            this.popUpConfig
          );
          dialogRef.componentInstance.languageItems = data;
          return dialogRef.afterClosed().pipe(
            map((confirm) => (confirm ? confirm : undefined)),
            filter((data) => !!data),
            tap((data) => {
              const controls = (
                this.addInternshipForm?.controls['translateTabs'] as FormArray
              ).controls;
              controls.push(
                buildFormGroupForTranslations(
                  undefined,
                  data !== undefined ? data.id : undefined,
                  data !== undefined ? data.name?.toString() : undefined
                )
              );
            })
          );
        }),
        take(1),
        takeUntil(this.destrojSubj$)
      )
      .subscribe();
  }
  public getFormGroupOutOfAbstractControl(
    abstractControl: AbstractControl
  ): FormGroup {
    return abstractControl as FormGroup;
  }
  public convertOptionToName(items: DepartementItemWithMinimalData[]) {
    return (id: number) => items.find((x) => x.id === id)?.name ?? '';
  }
  public compareLocation(o1: any, o2: any) {
    return o1?.id == o2?.id;
  }
  public addInternship() {
    console.log(this.internShipService.entityTobeUpdated);

    if (this.internShipService.entityTobeUpdated === undefined) {
      const newInternship = this.mapToSubmittableNewInternshipObject();
      console.log(newInternship);
      this.internShipService
        .createInternship(newInternship)
        .pipe(take(1), takeUntil(this.destrojSubj$))
        .subscribe();
    } else {
      const updatedInternship = this.mapToSubmittableUpdatedInternshipObject();
      this.internShipService
        .updateInternship(updatedInternship)
        .pipe(take(1), takeUntil(this.destrojSubj$))
        .subscribe();
    }
    this.router.navigateByUrl('/internships', {
      onSameUrlNavigation: 'reload',
    });
  }
  private mapToSubmittableNewInternshipObject() {
    const internShipToBeReturned: CreateInternship | undefined = {
      currentCountOfStudents:
        this.addInternshipForm?.controls['currentCountOfStudents'].value,
      maxCountOfStudents: this.addInternshipForm?.controls['maxStudents'].value,
      locations: this.addInternshipForm?.controls['locations'].value,
      schoolYear: this.addInternshipForm?.controls['schoolYear'].value,
      trainingType: this.addInternshipForm?.controls['trainingType'].value,
      unitId: this.addInternshipForm?.controls['unitId'].value,
      versions: convertFormsArrayToObjectForNewInternship(
        this.addInternshipForm?.controls['translateTabs'] as FormArray
      ),
    };
    return internShipToBeReturned;
  }
  private mapToSubmittableUpdatedInternshipObject() {
    const internShipToBeReturned: InternshipUpdateDto | undefined = {
      internShipId: this.addInternshipForm?.controls['internshipId'].value ?? 0,
      currentCountOfStudents:
        this.addInternshipForm?.controls['currentCountOfStudents'].value,
      maxCountOfStudents: this.addInternshipForm?.controls['maxStudents'].value,
      locations: this.addInternshipForm?.controls['locations'].value,
      schoolYear: this.addInternshipForm?.controls['schoolYear'].value,
      trainingType: this.addInternshipForm?.controls['trainingType'].value,
      unitId: this.addInternshipForm?.controls['unitId'].value,
      versions: convertFormsArrayToObjectForUpdatedInternship(
        this.addInternshipForm?.controls['translateTabs'] as FormArray
      ),
    };
    return internShipToBeReturned;
  }
}
