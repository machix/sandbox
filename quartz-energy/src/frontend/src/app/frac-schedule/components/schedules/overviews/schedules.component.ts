import { ScheduleOverviewsRequest } from './../../../models/schedules/overviews/schedule-overviews-request';
import { IScheduleOverviewsService } from './../../../services/schedules/overviews/i-schedule-overviews.service';
import { IScheduleOverviewsServiceToken } from './../../../services/schedules/overviews/i-schedule-overviews.service';
import { Component, OnInit, Inject } from '@angular/core';
import { MatTableOverviewsComponent } from '../../../../common/components/overviews/mat-table-overviews.component';
import { ScheduleOverviews } from '../../../models/schedules/overviews/schedule-overviews';
import { ScheduleOverview } from '../../../models/schedules/overviews/schedule-overview';
import { IProcessService, IProcessServiceToken } from '../../../../common/services/process/i-process-service';
import { IConfigServiceToken, IConfigService } from '../../../../common/services/config/i-config-service';

@Component({
  selector: 'app-schedules',
  templateUrl: './schedules.component.html',
  styles: []
})
export class SchedulesComponent
  extends MatTableOverviewsComponent<IScheduleOverviewsService,
                                      ScheduleOverviewsRequest,
                                      ScheduleOverviews,
                                      ScheduleOverview> {

    private displayedColumns = ['wellName',
      'operator',
      'fracStartDate',
      'fracEndDate',
      'duration',
      'api',
      'surface',
      'bottomhole',
      'tvd',
      'startIn'
    ];

    constructor(
        @Inject(IProcessServiceToken) protected processService: IProcessService,
        @Inject(IScheduleOverviewsServiceToken) protected overviewsService: IScheduleOverviewsService,
        @Inject(IConfigServiceToken) private configService: IConfigService) {
        super(
          processService,
          overviewsService,
          configService.getPageSize());
    }
}
