import { AboutPageComponent } from './pages/about-page/about-page.component';
import { SavedQueriesPageComponent } from './pages/saved-queries-page/saved-queries-page.component';
import { ListManagerPageComponent } from './pages/list-manager-page/list-manager-page.component';
import { NgModule, ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DashboardPageComponent } from './pages/dashboard-page/dashboard-page.component';
import { ResultPageComponent } from './pages/result-page/result-page.component';

const routes: Routes = [
  { path: 'dashboard-page', component: DashboardPageComponent },
  { path: 'result-page', component: ResultPageComponent },
  { path: 'list-manager', component: ListManagerPageComponent },
  { path: 'saved-queries', component: SavedQueriesPageComponent },
  { path: 'about', component: AboutPageComponent },
  { path: '**', redirectTo: 'dashboard-page' },
];

export const queryBuilderRouting: ModuleWithProviders = RouterModule.forRoot(routes);

