import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatToolbarModule} from '@angular/material/toolbar';
import { RouterModule } from '@angular/router';
@Component({
  selector: 'intern-rapp-navbar',
  standalone: true,
  imports: [CommonModule,MatToolbarModule,RouterModule],
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss'],
})
export class NavbarComponent {

 hello(){
  console.log("I was clicked")
  return "";
 }

}
