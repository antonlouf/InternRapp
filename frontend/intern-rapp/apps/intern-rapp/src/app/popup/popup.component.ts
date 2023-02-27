import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatDialogModule } from '@angular/material/dialog';
import {  MatButtonModule } from '@angular/material/button';
import {MatDividerModule} from '@angular/material/divider';
@Component({
  selector: 'intern-rapp-popup',
  standalone: true,
  imports: [CommonModule,MatDialogModule,MatButtonModule,MatDividerModule],
  templateUrl: './popup.component.html',
  styleUrls: ['./popup.component.scss'],
})
export class PopupComponent {

 
  

}
