import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import { MatDividerModule } from '@angular/material/divider';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { HttpClientModule } from '@angular/common/http';
import { MatIconModule } from '@angular/material/icon';
import { LanguageItem } from '../entities/languageItem';
import { Observable } from 'rxjs';

@Component({
  selector: 'intern-rapp-language-update-popup',
  standalone: true,
  imports: [CommonModule,MatDialogModule,MatDividerModule,ReactiveFormsModule,MatFormFieldModule,MatInputModule,HttpClientModule,MatIconModule],
  templateUrl: './language-update-popup.component.html',
  styleUrls: ['./language-update-popup.component.scss'],
})
export class LanguageUpdatePopupComponent {
  @Input() data!: LanguageItem
  updateForm=new FormGroup({
    languageName: new FormControl('',[Validators.required]),
  })
  managerEmailsAfterUpdate: string[]=[]
  constructor(public dialogRef: MatDialogRef<LanguageUpdatePopupComponent>){

  }
  ngOnInit(): void {
    this.updateForm.controls.languageName.patchValue(this.data?.name)
  }
  

    close(){
      this.data.name=this.updateForm.controls.languageName.getRawValue()
      this.dialogRef.close(this.updateForm.valid?this.data:undefined)
    }

}