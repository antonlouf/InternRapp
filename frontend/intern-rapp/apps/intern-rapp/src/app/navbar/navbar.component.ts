import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatToolbarModule} from '@angular/material/toolbar';
import { RouterModule } from '@angular/router';
import { UnitListComponent } from '../unit-list/unit-list.component';
@Component({
  selector: 'intern-rapp-navbar',
  standalone: true,
  imports: [CommonModule,MatToolbarModule,RouterModule,UnitListComponent],
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss'],
})
export class NavbarComponent {



}
