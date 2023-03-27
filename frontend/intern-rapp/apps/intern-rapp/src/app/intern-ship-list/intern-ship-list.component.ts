import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
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
import { filter, Observable, switchMap, Subject, tap, map } from 'rxjs';
import { PaginationFilterRequest } from '../entities/paginationFilterRequest';
import { CreateInternship } from '../entities/createInternship';
import { InternshipDetailItem } from '../entities/internshipDetailItem';
import { InternshipService } from '../services/internship.service';
import { FilterType } from '../enums/filterType';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';
import { InternshipItem } from '../entities/internshipItem';

@Component({
  selector: 'intern-rapp-intern-ship-list',
  standalone: true,
  imports: [CommonModule,MatDividerModule,MatIconModule,MatListModule,BaselistComponent,TranslateModule,ItemsTmplDirective,ReactiveFormsModule,HttpClientModule,MatDialogModule],
  templateUrl: './intern-ship-list.component.html',
  styleUrls: ['./intern-ship-list.component.scss'],
})
export class InternShipListComponent extends BaseList<InternshipItem> implements OnInit{
  public deleteSubject=new Subject<number>()
  public addSubject=new Subject<CreateInternship|undefined>();
  public updateSubject=new Subject<InternshipDetailItem>();
  
  constructor(private InternshipService: InternshipService,public dialog: MatDialog){
    super()
  }
  
  private  popUpConfig={
    width: '400px',
   closeOnNavigation:true,
   disableClose:false,
   hasBackdrop:true,
   position:{top:'250px',right:'500px'}
  }
  getGridItems$(paginationFilterRequest: PaginationFilterRequest): Observable<ResourceItemPagingResponse<InternshipItem>> {
    return this.InternshipService.filterAndPaginateLanguages(paginationFilterRequest)
  }
    ngOnInit(): void {
      this.filters=[{label:"languageNameLabel",name:"filterValue",type:FilterType.Text,observable:undefined}];
      
      // const delete$=this.configureDelete$();
      // const update$=this.configureUpdate$()
      // const add$=this.configureAdd$()
      // this.configureItems([delete$,update$,add$])
      this.configureItems(undefined)
    } 
  
  //   private configureDelete$(){
  // return this.deleteSubject.pipe(switchMap(id => 
  //   {
  //   const dialogRef= this.dialog.open(DeletePopupComponent, this.popUpConfig) 
  //   dialogRef.componentInstance.title="language"
  //   return dialogRef.afterClosed().pipe(map(confirm=>confirm ? id : undefined )
  // )})
  // ,filter(id => !!id)
  // ,switchMap(id =>  this.languageService.deleteLanguage(id)))
  //   }
    // private configureUpdate$(){
    //   return this.updateSubject.pipe(switchMap(data => 
    //     {
    //     const dialogRef= this.dialog.open(LanguageUpdatePopupComponent, this.popUpConfig) 
    //     dialogRef.componentInstance.data=data
    //     return dialogRef.afterClosed().pipe(map(confirm=>confirm ? data : undefined )
    //   )})
    //   ,filter(id => !!id)
    //   ,switchMap(languageItem=>{ 
    //     console.log(languageItem)
    //     return this.languageService.updateLanguage(languageItem)
        
    //     }))
    //     }
  
        // private configureAdd$(){
        //   return this.addSubject.pipe(switchMap(data => 
        //     {
        //     const dialogRef= this.dialog.open(LanguageAddPopupComponent, this.popUpConfig) 
        //     return dialogRef.afterClosed().pipe(map(confirm=> confirm!==undefined ? confirm : undefined
        //        )
        //   )})
        //   ,filter(id => !!id)
        //   ,switchMap(langItem => 
        //     {
        //     return  this.languageService.addLanguage(langItem)
        //     }))
        //     }
  
    filterUpdating(filter: {}){
      let filterString=""
      const record=filter as Record<string,never>
       this.filters?.forEach(x=>{
         filterString+=`unit:${record[x.name]},`
       })
       filterString = filterString.slice(0,filterString.length-1)
       this.filterUpdated(filterString)
    }
  //   addLanguage(){
  //   this.addSubject.next(undefined)
  //   }
  // updateLanguage=(item: DepartmentItem)=>{
  // this.updateSubject.next(item)
  // }
  // delete(id: number){ 
  //    this.deleteSubject.next(id)
  // }


}
