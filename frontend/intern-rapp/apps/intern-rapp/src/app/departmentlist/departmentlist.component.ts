import { Component, ViewChild, AfterViewInit, TemplateRef, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Department } from '../entities/departments';
import {MatTableModule} from '@angular/material/table';
import { MatFormFieldModule} from '@angular/material/form-field';
import {MatTableDataSource} from '@angular/material/table';
import {MatPaginator, MatPaginatorModule} from '@angular/material/paginator';
import { MatInputModule } from '@angular/material/input';
import { MatSort, MatSortModule } from '@angular/material/sort';
import {MatDialog, MatDialogModule} from '@angular/material/dialog';

import { PopupComponent } from '../popup/popup.component';
import { DeletePopupComponent } from '../delete-popup/delete-popup.component';
import { ComponentType } from '@angular/cdk/portal';

import { UpdatepopupComponent } from '../updatepopup/updatepopup.component';
import { FormsModule } from '@angular/forms';
import {MatCheckboxChange, MatCheckboxModule} from '@angular/material/checkbox';
import { User } from '../entities/user';
import { MatButtonModule } from '@angular/material/button';
const users=[
  {Id:1,Name: "matthias@realdolmen.com"},
  {Id:2,Name: "Niels@realdolmen.com"},
  {Id:3,Name: "Recep@realdolmen.com"},


]
const ELEMENT_DATA: Department[] = [
 {Id:1,Name:"Analysis Competence Center",managers:[users[0]]},
 {Id:2,Name:"Infrastructure",managers:[users[1]]},
 {Id:3,Name:"Java Competence Center",managers:[users[2]]},
 {Id:4,Name:"Low Code",managers:[users[1]]},
 {Id:5,Name:"Microsoft Business Solutions",managers:[users[2]]},
 {Id:6,Name:"SalesForce",managers:[users[1]]},
 {Id:7,Name:"WebDev",managers:[{Id:1,Name:"admin@hotmail.com"}]}
];

@Component({
  selector: 'intern-rapp-departmentlist',
  standalone: true,
  imports: [CommonModule,MatTableModule,MatFormFieldModule,MatPaginatorModule,MatInputModule,MatSortModule,MatDialogModule,PopupComponent,DeletePopupComponent,FormsModule,MatCheckboxModule,MatButtonModule],
  templateUrl: './departmentlist.component.html',
  styleUrls: ['./departmentlist.component.scss'],
})
export class DepartmentlistComponent implements AfterViewInit{
  @ViewChild('updateTemplate') updateTemplate!: TemplateRef<any>;
  @ViewChild('addTemplate') addTemplate!: TemplateRef<any>;
  displayedColumns: string[] = ['Name','actions'];
  dataToDisplay = [...ELEMENT_DATA];
  dataSource: MatTableDataSource<Department>;
  tempmanagers:User[]=[]
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  updatingItem :Department;
  itemToBeAdded: Department={Id:-1,Name:"",managers:[]};
userss :any;
  constructor(public dialog: MatDialog){
    this.dataSource=new MatTableDataSource(this.dataToDisplay)
    this.updatingItem= {Id:-1,Name:"",managers:[]};
    this.userss=users;
    
  }

    ngAfterViewInit(): void {
    this.dataSource.paginator=this.paginator;
    this.dataSource.sort=this.sort;
    }
  addData() {
    const randomElementIndex = Math.floor(Math.random() * ELEMENT_DATA.length);
    this.dataToDisplay = [...this.dataToDisplay, ELEMENT_DATA[randomElementIndex]];
    //this.dataSource.setData(this.dataToDisplay);
    this.dataSource.data=this.dataToDisplay
  }
  openDialog(template : ComponentType<any>) {
    const dialogRef = this.dialog.open(template,{
      width: '400px',
      closeOnNavigation:true,
      disableClose:false,
      hasBackdrop:true,
      position:{top:'140px',right:'700px'}
    });
    
  return dialogRef; 
  }

  removeData(id : number) {
    // console.log(this.dataToDisplay)
    this.dataToDisplay = this.dataToDisplay.filter(x=>x.Id!=id);
    // console.log(this.dataToDisplay)
// later make an actual API call for this 

   // this.dataSource.setData(this.dataToDisplay);
   this.dataSource.data=this.dataToDisplay;
  }

  openDeletConfirmation(id :number){
    const dialog=this.openDialog(DeletePopupComponent);
    dialog.componentInstance.dialog=dialog
    dialog.componentInstance.deleteAction.subscribe(()=>{
      this.removeData(id)
  });
 
  }
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }
  openUpdateDialog(department: Department){
    this.updatingItem.Id=department.Id;
    this.updatingItem.Name=department.Name;
    this.updatingItem.managers=department.managers;

    this.tempmanagers=this.updatingItem.managers;
    const dialog=this.openDialog(UpdatepopupComponent);
    
    dialog.componentInstance.dialog=dialog
    dialog.componentInstance.updatedEntityName="Update Department"
    dialog.componentInstance.actionName="update";
    dialog.componentInstance.iconClass="fa fa-edit";


    dialog.componentInstance.templateContent=this.updateTemplate
    dialog.componentInstance.submitAction.subscribe(()=>{
      const entityTobeUpdated=this.dataToDisplay.findIndex(x=>x.Id==this.updatingItem.Id)
      this.updatingItem.managers=this.tempmanagers;
      this.dataToDisplay[entityTobeUpdated]=this.updatingItem;
      this.dataSource.data=this.dataToDisplay;
  });
  dialog.afterClosed().subscribe(()=>{
    this.updatingItem={Id:-1,Name:"",managers:[]}
    this.tempmanagers=[];
  });
  }
  checkboxChange(event :MatCheckboxChange){
    if(event.checked){
      this.tempmanagers.push(users[parseInt(event.source.value)-1])
    }
    else{
      this.tempmanagers=this.tempmanagers.filter(x=>x.Id!=parseInt(event.source.value))
    }
 
  }
  checkIsSelectedManager(user : User){
    let isChecked=false;
    this.updatingItem.managers.forEach(x=>{
      if(x.Id===user.Id)isChecked=true;
    });

    return isChecked;
  }
  openAddPopup(){
    const dialog=this.openDialog(UpdatepopupComponent);
    
    dialog.componentInstance.dialog=dialog
    dialog.componentInstance.updatedEntityName="Add Department"
    dialog.componentInstance.templateContent=this.addTemplate
    dialog.componentInstance.actionName="add";
    dialog.componentInstance.iconClass="fa-plus";

    dialog.componentInstance.submitAction.subscribe(()=>{
    this.dataToDisplay.push(this.itemToBeAdded);
    this.dataSource.data=this.dataToDisplay;
  });
  dialog.afterClosed().subscribe(()=>{
    this.itemToBeAdded={Id:-1,Name:"",managers:[]}

  });
  }
  checkIsSelectedManagerByAdding(user : User){
    let isChecked=false;
    this.itemToBeAdded.managers.forEach(x=>{
      if(x.Id===user.Id)isChecked=true;
    });

    return isChecked; 
  }
  checkboxChangeByAdding(event: MatCheckboxChange){
    if(event.checked){
      this.itemToBeAdded.managers.push(users[parseInt(event.source.value)-1])
    }
    else{
      this.itemToBeAdded.managers=this.itemToBeAdded.managers.filter(x=>x.Id!=parseInt(event.source.value))
    }
  }
}


