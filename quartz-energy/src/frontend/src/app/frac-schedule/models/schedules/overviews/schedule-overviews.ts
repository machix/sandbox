import { ScheduleOverviewsRequest } from './schedule-overviews-request';
import { Overviews } from '../../../../common/models/overviews/overviews';
import { ScheduleOverview } from './schedule-overview';
import { ScheduleSummary } from './schedule-summary';

export class ScheduleOverviews extends Overviews<ScheduleOverviewsRequest, ScheduleOverview> {
    constructor(
      public request: ScheduleOverviewsRequest,
      public recordsCount: number,
      public overviews: ScheduleOverview[],
      public summary: ScheduleSummary) {
      super(request, recordsCount, overviews);
    }
}
