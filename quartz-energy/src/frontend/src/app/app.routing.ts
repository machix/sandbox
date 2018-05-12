import { HomeComponent } from './vega/components/home/home.component';
import { fracScheduleRoutes } from './frac-schedule/frac-schedule.routing';
import { vegaRoutes } from './vega/vega.routing';
import { RouterModule, Routes } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';

let appRoutes: Routes = [
    {
      path: 'vega',
      component: HomeComponent,
      pathMatch: 'full'
    },
    {
        path: '**',
        redirectTo: ''
    }
];

appRoutes = vegaRoutes.concat(fracScheduleRoutes, appRoutes);
export const appRouting: ModuleWithProviders = RouterModule.forRoot(appRoutes);
