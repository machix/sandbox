import { ScheduleStatus } from './../../enums/schedule-status';
import { NumberIdBusinessModel } from '../../../../common/models/entity/number-id-business-model';

export class ScheduleOverview extends NumberIdBusinessModel {
    constructor(
        public id: number,
        public scheduleId: number,
        public wellName: string,
        public operator: string,
        public fracStartDate: Date,
        public fracEndDate: Date,
        public duration: number,
        public api: string,
        public surfaceLat: number,
        public surfaceLong: number,
        public bottomholeLat: number,
        public bottomholeLong: number,
        public tvd: string,
        public startIn: number,
        public status: ScheduleStatus
    ) {
        super(id);
    }
}
