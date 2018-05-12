import { Routes } from '@angular/router';
import { AuthGuard } from '../common/guards/auth-guard';
import { FracScheduleComponent } from './frac-schedule.component';

export const fracScheduleRoutes: Routes = [
  {
    path: 'schedules',
    component: FracScheduleComponent,
    pathMatch: 'full',
    canActivate: [AuthGuard]
  }
];
