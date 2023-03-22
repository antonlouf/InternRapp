import { B } from '@angular/cdk/keycodes';
import { Route } from '@angular/router';
import { LanguageListComponent } from './language-list/language-list.component';
import { UnitListComponent } from './unit-list/unit-list.component';


export const appRoutes: Route[] = [
    {
        path: 'departments', component: UnitListComponent
    },
    {
        path: 'language', component: LanguageListComponent
    },
    { path: '**', redirectTo: '/departments', pathMatch: 'full' }
];
