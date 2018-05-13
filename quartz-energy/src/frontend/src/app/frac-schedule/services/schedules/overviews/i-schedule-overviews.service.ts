import { InjectionToken } from '@angular/core';
import { ScheduleOverviewsRequest } from './../../../models/schedules/overviews/schedule-overviews-request';
import { IOverviewsService } from './../../../../common/services/overviews/i-overviews.service';
import { ScheduleOverviews } from '../../../models/schedules/overviews/schedule-overviews';

// tslint:disable-next-line:no-empty-interface
export interface IScheduleOverviewsService
    extends IOverviewsService<ScheduleOverviewsRequest, ScheduleOverviews> {
}

export const IScheduleOverviewsServiceToken = new InjectionToken<IScheduleOverviewsService>('IScheduleOverviewsService');
