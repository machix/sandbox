import { ScheduleOverviewsRequest } from './../../../../models/schedules/overviews/schedule-overviews-request';
import { Injectable, Inject } from '@angular/core';
import { OverviewsService } from '../../../../../common/services/overviews/concrete/overviews.service';
import { ScheduleOverviews } from '../../../../models/schedules/overviews/schedule-overviews';
import { IScheduleOverviewsService } from '../i-schedule-overviews.service';
import { IConfigServiceToken, IConfigService } from '../../../../../common/services/config/i-config-service';

@Injectable()
export class ScheduleOverviewsService
        extends OverviewsService<ScheduleOverviewsRequest, ScheduleOverviews>
        implements IScheduleOverviewsService {
      constructor (
        @Inject(IConfigServiceToken) private configService: IConfigService) {
        super();
      }

      protected getBaseUrl(): string {
          return this.configService.getApiBaseUrl() + 'schedules';
      }
  }
