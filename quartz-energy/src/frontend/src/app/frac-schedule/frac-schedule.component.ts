import { ScheduleOverviewsService } from './services/schedules/overviews/concrete/schedule-overviews.service';
import { IScheduleOverviewsServiceToken } from './services/schedules/overviews/i-schedule-overviews.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-frac-schedule',
  templateUrl: './frac-schedule.component.html',
  styles: [],
  providers: [
    { provide: IScheduleOverviewsServiceToken, useClass: ScheduleOverviewsService }
  ]
})
export class FracScheduleComponent {
}
