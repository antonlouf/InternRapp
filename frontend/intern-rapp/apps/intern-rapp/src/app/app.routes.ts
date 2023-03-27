import { B } from '@angular/cdk/keycodes';
import { Route } from '@angular/router';
import { LanguageListComponent } from './language-list/language-list.component';
import { UnitListComponent } from './unit-list/unit-list.component';
import { InternShipListComponent } from './intern-ship-list/intern-ship-list.component';


export const appRoutes: Route[] = [
    {
        path: 'departments', component: UnitListComponent
    },
    {
        path: 'languages', component: LanguageListComponent
    },
    {
        path: 'internships', component: InternShipListComponent
    },
    { path: '**', redirectTo: '/departments', pathMatch: 'full' }
];
