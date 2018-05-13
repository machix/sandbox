import { FracScheduleConfigService } from './services/common/concrete/frac-schedule-config.service';
import { IConfigServiceToken } from './../common/services/config/i-config-service';
import { RouterModule } from '@angular/router';
import { AppCommonModule } from './../common/app-common.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, ModuleWithProviders } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatTabsModule } from '@angular/material/tabs';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatCardModule } from '@angular/material/card';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatSortModule } from '@angular/material/sort';
import { ChartsModule } from 'ng2-charts/ng2-charts';
import { FracScheduleComponent } from './frac-schedule.component';
import { SchedulesComponent } from './components/schedules/overviews/schedules.component';
import { ScheduleOverviewComponent } from './components/schedules/overviews/schedule-overview.component';
import { SchedulesFilterComponent } from './components/schedules/overviews/schedules-filter.component';

@NgModule({
  declarations: [
  FracScheduleComponent,
  SchedulesComponent,
  ScheduleOverviewComponent,
  SchedulesFilterComponent],
  imports: [
    AppCommonModule.forRoot(),
    RouterModule,
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatTabsModule,
    MatFormFieldModule,
    MatButtonModule,
    MatInputModule,
    MatSelectModule,
    MatCardModule,
    MatCheckboxModule,
    ChartsModule
  ],
  exports: [
    FracScheduleComponent
  ],
  bootstrap: [FracScheduleComponent]
})
export class FracScheduleModule {
  public static forRoot(): ModuleWithProviders {
    return {
      ngModule: FracScheduleModule,
      providers: [
        { provide: IConfigServiceToken, useClass: FracScheduleConfigService }
      ]
    };
  }
}
