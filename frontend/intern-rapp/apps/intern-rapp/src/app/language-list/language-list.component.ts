import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DepartmentItem } from '../entities/departmentItem';
import { LanguageService } from '../services/language.service';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { PaginationFilterRequest } from '../entities/paginationFilterRequest';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';
import { filter, Observable, switchMap, Subject, tap, map } from 'rxjs';
import { CreateDepartment } from '../entities/CreateDepartment';
import { BaseList } from '../baselist/baseList';
import { LanguageItem } from '../entities/languageItem';
import { CreateLanguage } from '../entities/createLanguage';
import { FilterType } from '../enums/filterType';
import { DeletePopupComponent } from '../delete-popup/delete-popup.component';
import { LanguageUpdatePopupComponent } from '../language-update-popup/language-update-popup.component';
import { LanguageAddPopupComponent } from '../language-add-popup/language-add-popup.component';
import { MatDividerModule } from '@angular/material/divider';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { BaselistComponent } from '../baselist/baselist.component';
import { ItemsTmplDirective } from '../items-tmpl.directive';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'intern-rapp-language-list',
  standalone: true,
  imports: [CommonModule,MatDividerModule,MatIconModule,MatListModule,BaselistComponent,ItemsTmplDirective,ReactiveFormsModule,HttpClientModule,MatDialogModule],
  templateUrl: './language-list.component.html',
  styleUrls: ['./language-list.component.scss'],
})
export class LanguageListComponent extends BaseList<LanguageItem>{
  public deleteSubject=new Subject<number>()
  public addSubject=new Subject<CreateLanguage|undefined>();
  public updateSubject=new Subject<LanguageItem>();
  
  constructor(private languageService: LanguageService,public dialog: MatDialog){
    super()
  }
  
  private  popUpConfig={
    width: '400px',
   closeOnNavigation:true,
   disableClose:false,
   hasBackdrop:true,
   position:{top:'250px',right:'500px'}
  }
  getGridItems$(paginationFilterRequest: PaginationFilterRequest): Observable<ResourceItemPagingResponse<LanguageItem>> {
    return this.languageService.filterAndPaginateLanguages(paginationFilterRequest)
  }
    ngOnInit(): void {
      this.filters=[{label:"Language name",name:"filterValue",type:FilterType.Text,observable:undefined}];
      const delete$=this.configureDelete$();
      const update$=this.configureUpdate$()
      const add$=this.configureAdd$()
      this.configureItems([delete$,update$,add$])
    } 
  
    private configureDelete$(){
  return this.deleteSubject.pipe(switchMap(id => 
    {
    const dialogRef= this.dialog.open(DeletePopupComponent, this.popUpConfig) 
    dialogRef.componentInstance.title="Language"
    return dialogRef.afterClosed().pipe(map(confirm=>confirm ? id : undefined )
  )})
  ,filter(id => !!id)
  ,switchMap(id =>  this.languageService.deleteLanguage(id)))
    }
    private configureUpdate$(){
      return this.updateSubject.pipe(switchMap(data => 
        {
        const dialogRef= this.dialog.open(LanguageUpdatePopupComponent, this.popUpConfig) 
        dialogRef.componentInstance.data=data
        return dialogRef.afterClosed().pipe(map(confirm=>confirm ? data : undefined )
      )})
      ,filter(id => !!id)
      ,switchMap(languageItem=>{ 
        console.log(languageItem)
        return this.languageService.updateLanguage(languageItem)
        
        }))
        }
  
        private configureAdd$(){
          return this.addSubject.pipe(switchMap(data => 
            {
            const dialogRef= this.dialog.open(LanguageAddPopupComponent, this.popUpConfig) 
            return dialogRef.afterClosed().pipe(map(confirm=> confirm!==undefined ? confirm : undefined
               )
          )})
          ,filter(id => !!id)
          ,switchMap(langItem => 
            {
            return  this.languageService.addLanguage(langItem)
            }))
            }
  
    filterUpdating(filter: {}){
      let filterString=""
      const record=filter as Record<string,never>
       this.filters?.forEach(x=>{
         filterString+=`unit:${record[x.name]},`
       })
       filterString = filterString.slice(0,filterString.length-1)
       this.filterUpdated(filterString)
    }
    addDepartment(){
    this.addSubject.next(undefined)
    }
  updateDepartment=(item: DepartmentItem)=>{
  this.updateSubject.next(item)
  }
  delete(id: number){ 
     this.deleteSubject.next(id)
  }


}