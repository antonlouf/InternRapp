import { ChangeDetectionStrategy, Component, inject, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { MatSelectModule } from '@angular/material/select';
import { MatListModule } from '@angular/material/list';
import { filter, Observable, switchMap, Subject, tap } from 'rxjs';
import {  BaselistComponent } from '../baselist/baselist.component';
import { DepartmentService } from '../services/department.service';
import { HttpClient, HttpClientModule } from '@angular/common/http';

import { PaginationFilterRequest } from '../entities/paginationFilterRequest';
import { ItemsTmplDirective } from '../items-tmpl.directive';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { DeletePopupComponent } from '../delete-popup/delete-popup.component';
import { Filter } from '../entities/filter';
import { FilterType } from '../enums/filterType';
import { map } from 'rxjs/operators';
import { DepartmentItem } from '../entities/departmentItem';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';
import { PaginationRequest } from '../entities/paginationRequest';
import {BaseList} from '../baselist/baseList'
import { DepartmentUpdateComponent } from '../department-update/department-update.component';
import { CreateDepartment } from '../entities/CreateDepartment';
import { DepartmentAddPopupComponent } from '../department-add-popup/department-add-popup.component';
@Component({
  selector: 'intern-rapp-unit-list',
  standalone: true,
  imports: [CommonModule,MatListModule,MatDialogModule,MatSelectModule,ReactiveFormsModule,HttpClientModule,ItemsTmplDirective,MatListModule,MatIconModule,MatInputModule,BaselistComponent,DeletePopupComponent],
  templateUrl: './unit-list.component.html',
  styleUrls: ['./unit-list.component.scss'],
  providers:[HttpClient,DepartmentService]
})
export class UnitListComponent extends BaseList<DepartmentItem> implements OnInit{
 

public deleteSubject=new Subject<number>()
public addSubject=new Subject<CreateDepartment|undefined>();
public updateSubject=new Subject<DepartmentItem>();

constructor(private unitService: DepartmentService,public dialog: MatDialog){
  super()
}

private  popUpConfig={
  width: '400px',
 closeOnNavigation:true,
 disableClose:false,
 hasBackdrop:true,
 position:{top:'250px',right:'500px'}
}
getGridItems$(paginationFilterRequest: PaginationFilterRequest): Observable<ResourceItemPagingResponse<DepartmentItem>> {
  return this.unitService.filter(paginationFilterRequest)
}
  ngOnInit(): void {
    this.filters=[{label:"Department name",name:"filterValue",type:FilterType.Text,observable:undefined}];
    const delete$=this.configureDelete$();
    const update$=this.configureUpdate$()
    const add$=this.configureAdd$()
    this.configureItems([delete$,update$,add$])
  } 

  private configureDelete$(){
return this.deleteSubject.pipe(switchMap(id => 
  {
  const dialogRef= this.dialog.open(DeletePopupComponent, this.popUpConfig) 
  dialogRef.componentInstance.title="department"
  return dialogRef.afterClosed().pipe(map(confirm=>confirm ? id : undefined )
)})
,filter(id => !!id)
,switchMap(id => this.unitService.deleteDepartment(id)))
  }
  private configureUpdate$(){
    return this.updateSubject.pipe(switchMap(data => 
      {
      const dialogRef= this.dialog.open(DepartmentUpdateComponent, this.popUpConfig) 
      dialogRef.componentInstance.data=data
      return dialogRef.afterClosed().pipe(map(confirm=>confirm ? data : undefined )
    )})
    ,filter(id => !!id)
    ,switchMap(depItem => this.unitService.updateDepartment(depItem)))
      }

      private configureAdd$(){
        return this.addSubject.pipe(switchMap(data => 
          {
          const dialogRef= this.dialog.open(DepartmentAddPopupComponent, this.popUpConfig) 
          return dialogRef.afterClosed().pipe(map(confirm=> confirm!==undefined ? confirm : undefined
             )
        )})
        ,filter(id => !!id)
        ,switchMap(depItem => 
          {
          return  this.unitService.addDepartment(depItem)
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
