import { CompaniesListService } from './services/companies/lists/concrete/companies-list.service';
import { ICompaniesListServiceToken } from './services/companies/lists/i-companies-list.service';
import { RegionsListService } from './services/regions/lists/concrete/regions-list.service';
import { IRegionsListServiceToken } from './services/regions/lists/i-regions-list.service';
import { ScheduleOverviewsService } from './services/schedules/overviews/concrete/schedule-overviews.service';
import { IScheduleOverviewsServiceToken } from './services/schedules/overviews/i-schedule-overviews.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-frac-schedule',
  templateUrl: './frac-schedule.component.html',
  styles: [],
  providers: [
    { provide: IScheduleOverviewsServiceToken, useClass: ScheduleOverviewsService },
    { provide: IRegionsListServiceToken, useClass: RegionsListService },
    { provide: ICompaniesListServiceToken, useClass: CompaniesListService },
  ]
})
export class FracScheduleComponent {
}
