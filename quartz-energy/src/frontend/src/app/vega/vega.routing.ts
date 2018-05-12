import { LoginComponent } from './components/auth/login/login.component';
import { VehicleComponent } from './components/vehicles/entity/vehicle.component';
import { HomeComponent } from './components/home/home.component';
import { Routes } from '@angular/router';
import { VehiclesComponent } from './components/vehicles/overviews/vehicles.component';
import { AboutComponent } from './components/about/about.component';
import { VehiclesStatisticsComponent } from './components/vehicles/statistics/vehicles-statistics.component';
import { RegisterComponent } from './components/auth/register/register.component';
import { AuthGuard } from '../common/guards/auth-guard';

export const vegaRoutes: Routes = [
    {
      path: '',
      component: HomeComponent,
      pathMatch: 'full'
    },
    {
      path: 'vehicles',
      component: VehiclesComponent,
      pathMatch: 'full',
      canActivate: [AuthGuard]
    },
    {
      path: 'vehicles/new',
      component: VehicleComponent,
      canActivate: [AuthGuard]
    },
    {
      path: 'vehicles/:id',
      component: VehicleComponent,
      canActivate: [AuthGuard]
    },
    {
      path: 'statistics',
      component: VehiclesStatisticsComponent,
      canActivate: [AuthGuard]
    },
    {
      path: 'about',
      component: AboutComponent,
      canActivate: [AuthGuard]
    },
    {
      path: 'register',
      component: RegisterComponent
    },
    {
      path: 'login',
      component: LoginComponent
    }
  ];
