import { Component, Input, Output, EventEmitter, TemplateRef } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { PopupComponent } from '../popup/popup.component';

@Component({
  selector: 'intern-rapp-updatepopup',
  standalone: true,
  imports: [CommonModule,PopupComponent],
  templateUrl: './updatepopup.component.html',
  styleUrls: ['./updatepopup.component.scss'],
})
export class UpdatepopupComponent {

  @Input() updatedEntityName="";
  @Input() actionName="";
  @Input() iconClass="";


  @Input() dialog!: MatDialogRef<UpdatepopupComponent>;
  @Input() templateContent!: TemplateRef<any>;

  @Output() submitAction=new EventEmitter();

  delete(){
    this.submitAction.emit();
    this.dialog.close();
    
  }
}
