import { ScheduleOverview } from './../../../models/schedules/overviews/schedule-overview';
import { Component, OnInit } from '@angular/core';
import { OverviewComponent } from '../../../../common/components/overviews/overview.component';

@Component({
  selector: 'app-schedule-overview',
  templateUrl: './schedule-overview.component.html',
  styles: []
})
export class ScheduleOverviewComponent extends OverviewComponent<ScheduleOverview> implements OnInit {

  constructor() {
    super();
  }

  ngOnInit() {
  }

}
