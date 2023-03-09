import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import { MatDividerModule } from '@angular/material/divider';
import { ReactiveFormsModule, FormGroup, FormControl, Validators } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import {MatAutocompleteModule} from '@angular/material/autocomplete';
import {  DepartmentService } from '../services/department.service';
import { catchError, debounceTime, distinctUntilChanged, EMPTY, Observable, startWith, switchMap } from 'rxjs';
import { MatInputModule } from '@angular/material/input';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { MatOptionSelectionChange } from '@angular/material/core';
import {MatChipInputEvent, MatChipsModule} from '@angular/material/chips';
import {MatIconModule} from '@angular/material/icon';
import {COMMA, ENTER} from '@angular/cdk/keycodes';
import { CreateDepartment } from '../entities/CreateDepartment';
@Component({
  selector: 'intern-rapp-department-add-popup',
  standalone: true,
  imports: [CommonModule,MatDialogModule,MatDividerModule,ReactiveFormsModule,MatFormFieldModule,MatAutocompleteModule,MatInputModule,HttpClientModule,MatChipsModule,MatIconModule],
  templateUrl: './department-add-popup.component.html',
  styleUrls: ['./department-add-popup.component.scss'],
  providers:[HttpClient,DepartmentService]
})
export class DepartmentAddPopupComponent implements OnInit{
filteredOptions!:Observable<(string|undefined)[]>
separatorKeysCodes: number[] = [ENTER, COMMA];
options:string[]=[]
addForm=new FormGroup({
departmentName: new FormControl('',[Validators.required]),
managerEmails:new FormControl('')
})

managerEmailsTobeAdded: string[]=[]

constructor(private unitService: DepartmentService,public dialogRef: MatDialogRef<DepartmentAddPopupComponent>) {
  
}
add(event: MatChipInputEvent): void {
  const value = (event.value || '').trim();

  // Add email of the manager
  if (value) {
    this.managerEmailsTobeAdded.push(value);
  }

  // Clear the input value
  // eslint-disable-next-line @typescript-eslint/no-non-null-assertion
  event.chipInput!.clear();
  this.addForm.controls.managerEmails.setValue(null);
}
ngOnInit(): void {
  //backend is going to change the data it is returning(at the moment it is mocked data)
 
  this.filteredOptions  = this.addForm.controls.managerEmails.valueChanges.pipe(
    startWith(''),
    debounceTime(300),
    distinctUntilChanged(),
    //map(searchString=>searchString as string|undefined)),
    switchMap(searchString=>this.unitService.getAllSupervisorNamesContaining(searchString as string|undefined).pipe(catchError(()=>EMPTY))),
  );
  
}

addToListOfManagers(event: MatOptionSelectionChange){
this.addForm.controls.managerEmails.patchValue(event.source.value.toString())
}
closeDialog(save:boolean){
  let data: CreateDepartment|undefined
  if(save){
    data={name:this.addForm.controls.departmentName.getRawValue(),superVisorEmails:this.managerEmailsTobeAdded}
  }
  console.log('in close')
  console.log(save)
  this.dialogRef.close(save?data:undefined)
}

remove(managerEmail: string): void {
  this.managerEmailsTobeAdded=this.managerEmailsTobeAdded.filter(x=>x!=managerEmail)
}
}
