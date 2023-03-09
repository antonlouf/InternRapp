import { bootstrapApplication } from '@angular/platform-browser';
import {
  provideRouter,
  withEnabledBlockingInitialNavigation,
} from '@angular/router';
import { AppComponent } from './app/app.component';
import { appRoutes } from './app/app.routes';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { importProvidersFrom } from '@angular/core';
import { HttpClientModule, provideHttpClient } from '@angular/common/http';
import { MatTableModule } from '@angular/material/table';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { DepartmentService } from './app/services/department.service';

bootstrapApplication(AppComponent, {
  providers: [provideRouter(appRoutes, withEnabledBlockingInitialNavigation()), importProvidersFrom(BrowserAnimationsModule, BrowserAnimationsModule, BrowserAnimationsModule,HttpClientModule,MatTableModule,MatFormFieldModule,MatPaginatorModule,MatSortModule)],
}).catch((err) => console.error(err));
