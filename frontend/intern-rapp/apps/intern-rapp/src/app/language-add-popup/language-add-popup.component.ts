import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatDividerModule } from '@angular/material/divider';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { HttpClientModule } from '@angular/common/http';
import { MatIconModule } from '@angular/material/icon';
import { MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import { LanguageItem } from '../entities/languageItem';
import { CreateLanguage } from '../entities/createLanguage';
import { TranslateModule } from '@ngx-translate/core';

@Component({
  selector: 'intern-rapp-language-add-popup',
  standalone: true,
  imports: [CommonModule,MatDialogModule,MatDividerModule,TranslateModule,ReactiveFormsModule,MatFormFieldModule,MatInputModule,HttpClientModule,MatIconModule],
  templateUrl: './language-add-popup.component.html',
  styleUrls: ['./language-add-popup.component.scss'],
})
export class LanguageAddPopupComponent {
  addForm=new FormGroup({
    languageName: new FormControl('',[Validators.required]),
    })
  constructor(public dialogRef: MatDialogRef<LanguageAddPopupComponent>) {
  
  }
  
  closeDialog(save:boolean){
    let data: CreateLanguage|undefined
    if(save){
      data={name:this.addForm.controls.languageName.getRawValue()}
    }

    this.dialogRef.close(save?data:undefined)
  }
  

}
