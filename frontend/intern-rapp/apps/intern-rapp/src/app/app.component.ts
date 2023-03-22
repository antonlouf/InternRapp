 import { NxWelcomeComponent } from './nx-welcome.component';
import { RouterModule } from '@angular/router';
import { Component } from '@angular/core';
import {MatToolbarModule} from '@angular/material/toolbar';
import { NavbarComponent } from './navbar/navbar.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClient, HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { UnitListComponent } from './unit-list/unit-list.component';
import { TranslateModule,TranslateLoader } from '@ngx-translate/core';
import { customTranslate } from './loader/customTranslate';
import { AcceptHeaderInterceptor } from './interceptors/accept-header.interceptor';

@Component({
  standalone: true,
  imports: [NxWelcomeComponent, RouterModule,MatToolbarModule,NavbarComponent, ReactiveFormsModule,HttpClientModule,UnitListComponent,
  ],
  selector: 'intern-rapp-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  title = 'intern-rapp';
}
