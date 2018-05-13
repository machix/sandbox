import { OverviewsRequest } from './../../../../common/models/overviews/overviews-request';

export class ScheduleOverviewsRequest extends OverviewsRequest {
    constructor (
        public regions: number[],
        public operators: number[],
        public startNextDays: number,
        public sortBy: string,
        public desc: boolean,
        public pageSize: number,
        public pageNumber: number) {
      super(sortBy, desc, pageSize, pageNumber);
    }
}
