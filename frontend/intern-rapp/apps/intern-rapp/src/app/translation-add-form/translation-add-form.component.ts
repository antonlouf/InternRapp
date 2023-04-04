import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormGroup, ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { TranslateModule } from '@ngx-translate/core';
import { MatInputModule } from '@angular/material/input';
import { MatDialogModule } from '@angular/material/dialog';
import { MatIconModule } from '@angular/material/icon';
@Component({
  selector: 'intern-rapp-translation-add-form',
  standalone: true,
  imports: [CommonModule,ReactiveFormsModule,MatFormFieldModule,TranslateModule,MatInputModule,MatDialogModule,MatIconModule],
  templateUrl: './translation-add-form.component.html',
  styleUrls: ['./translation-add-form.component.scss'],
})
export class TranslationAddFormComponent {
  @Input() internshipTranslationForm:FormGroup|undefined
}
