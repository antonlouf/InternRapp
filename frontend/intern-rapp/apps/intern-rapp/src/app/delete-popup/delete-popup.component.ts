import { Component, Input, Output,EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PopupComponent } from '../popup/popup.component';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogRef } from '@angular/material/dialog';


@Component({
  selector: 'intern-rapp-delete-popup',
  standalone: true,
  imports: [CommonModule,PopupComponent,MatButtonModule],
  templateUrl: './delete-popup.component.html',
  styleUrls: ['./delete-popup.component.scss'],
})
export class DeletePopupComponent {

  
  @Input() deletedItem="";
  @Output() deleteAction=new EventEmitter();
  @Input() dialog!: MatDialogRef<DeletePopupComponent>;

  delete(){
    this.deleteAction.emit();
    this.cancel();

  }
  cancel(){
    this.dialog.close();
  }
}
