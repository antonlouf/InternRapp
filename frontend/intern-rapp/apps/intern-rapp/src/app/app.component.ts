 import { NxWelcomeComponent } from './nx-welcome.component';
import { RouterModule } from '@angular/router';
import { Component } from '@angular/core';
import {MatToolbarModule} from '@angular/material/toolbar';
import { NavbarComponent } from './navbar/navbar.component';
import { FormGroup, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { UnitListComponent } from './unit-list/unit-list.component';



@Component({
  standalone: true,
  imports: [NxWelcomeComponent, RouterModule,MatToolbarModule,NavbarComponent, ReactiveFormsModule,HttpClientModule,UnitListComponent],
  selector: 'intern-rapp-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  title = 'intern-rapp';
}
