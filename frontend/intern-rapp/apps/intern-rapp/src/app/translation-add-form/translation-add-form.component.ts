import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormGroup, ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { TranslateModule } from '@ngx-translate/core';
import { MatInputModule } from '@angular/material/input';
import { MatDialogModule } from '@angular/material/dialog';
import { MatIconModule } from '@angular/material/icon';
import { AngularEditorConfig, AngularEditorModule } from '@kolkov/angular-editor';
@Component({
  selector: 'intern-rapp-translation-add-form',
  standalone: true,
  imports: [
    CommonModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    AngularEditorModule,
    TranslateModule,
    MatInputModule,
    MatDialogModule,
    MatIconModule,
  ],
  templateUrl: './translation-add-form.component.html',
  styleUrls: ['./translation-add-form.component.scss'],
})
export class TranslationAddFormComponent {
  @Input() internshipTranslationForm: FormGroup | undefined;
  editorConfig: AngularEditorConfig = {
    editable: true,
    spellcheck: true,
    height: '250px',
    minHeight: '0',
    maxHeight: 'auto',
    width: 'auto', 
    minWidth: '0',
    translate: 'yes',
    enableToolbar: true,
    showToolbar: true,
    placeholder: '',
    defaultParagraphSeparator: '',
    // defaultFontName: 'Verdana',
    // defaultFontSize: '7px',
    // fonts: [{ class: 'Verdana', name: 'Verdana' }],
    toolbarHiddenButtons: [
      [
        'undo',
        'redo',
        'underline',
        'fonSize',
        'strikeThrough',
        'subscript',
        'superscript',
        'justifyLeft',
        'justifyCenter',
        'justifyRight',
        'justifyFull',
        'indent',
        'outdent',
        'fontName',
      ],
      [
        'fontSize',
        'textColor',
        'backgroundColor',
        'link',
        'unlink',
        'insertImage',
        'insertVideo',
        'insertHorizontalRule',
        'removeFormat',
        'toggleEditorMode',
      ],
    ],
  };
}
