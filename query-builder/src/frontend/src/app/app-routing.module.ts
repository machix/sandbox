import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DashboardPageComponent } from './pages/dashboard-page/dashboard-page.component';
import { ResultPageComponent } from './pages/result-page/result-page.component';

const routes: Routes = [
  { path: 'dashboard-page', component: DashboardPageComponent },
  { path: 'result-page', component: ResultPageComponent },
  { path: '**', redirectTo: 'dashboard-page' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
