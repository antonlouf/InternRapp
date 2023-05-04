import { B } from '@angular/cdk/keycodes';
import { Route } from '@angular/router';
import { LanguageListComponent } from './language-list/language-list.component';
import { LocationListComponent } from './location-list/location-list.component';
import { UnitListComponent } from './unit-list/unit-list.component';
import { InternShipListComponent } from './intern-ship-list/intern-ship-list.component';
import { InternshipAddComponent } from './internship-add/internship-add.component';
import { InternshipDetailItem } from './entities/internshipDetailItem';

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
    {
        path: 'internships/create', component: InternshipAddComponent,data:{internshipTobeUpdated:undefined}
    },
    {
        path: 'locations', component: LocationListComponent
    },
    { path: '**', redirectTo: '/departments', pathMatch: 'full' }
];
