import { Component, Input, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import { MatDividerModule } from '@angular/material/divider';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatInputModule } from '@angular/material/input';
import { HttpClientModule } from '@angular/common/http';
import { MatChipInputEvent, MatChipsModule } from '@angular/material/chips';
import { MatIconModule } from '@angular/material/icon';
import {COMMA, ENTER} from '@angular/cdk/keycodes';
import { Observable } from 'rxjs';
import { CreateDepartment } from '../entities/CreateDepartment';
import { MatOptionSelectionChange } from '@angular/material/core';
import { DepartmentItem } from '../entities/departmentItem';

@Component({
  selector: 'intern-rapp-department-update',
  standalone: true,
  imports: [CommonModule,MatDialogModule,MatDividerModule,ReactiveFormsModule,MatFormFieldModule,MatAutocompleteModule,MatInputModule,HttpClientModule,MatChipsModule,MatIconModule],
  templateUrl: './department-update.component.html',
  styleUrls: ['./department-update.component.scss'],
})
export class DepartmentUpdateComponent implements OnInit{
 
  @Input() data!: DepartmentItem
  filteredOptions!:Observable<(string|undefined)[]>
  separatorKeysCodes: number[] = [ENTER, COMMA];
  options:string[]=[]
  updateForm=new FormGroup({
  departmentName: new FormControl('',[Validators.required]),
  managerEmails:new FormControl('')
  })
  managerEmailsAfterUpdate: string[]=[]
  constructor(public dialogRef: MatDialogRef<DepartmentUpdateComponent>){

  }
  ngOnInit(): void {
    this.updateForm.controls.departmentName.patchValue(this.data?.name)
    this.managerEmailsAfterUpdate=this.data?.managerEmails
  }
  add(event: MatChipInputEvent): void {
    const value = (event.value || '').trim();
  
    // Add email of the manager
    console.log(value)
    if (value) {
      this.managerEmailsAfterUpdate.push(value);
    }
  
    // Clear the input value
    // eslint-disable-next-line @typescript-eslint/no-non-null-assertion
    event.chipInput!.clear();
    this.updateForm.controls.managerEmails.setValue(null);
  }
  remove(managerEmail: string): void {
    this.managerEmailsAfterUpdate=this.managerEmailsAfterUpdate.filter(x=>x!=managerEmail)
  }
  addToListOfManagers(event: MatOptionSelectionChange){
    this.updateForm.controls.managerEmails.patchValue(event.source.value.toString())
    }
    close(){
      console.log('hello')
      this.data.managerEmails=this.managerEmailsAfterUpdate
      this.dialogRef.close(this.updateForm.valid?this.data:undefined)
    }
}
