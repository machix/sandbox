export class ScheduleSummary {
    constructor(
        public operatingCount: number,
        public next7DaysCount: number,
        public next830DaysCount: number,
        public next3160DaysCount: number,
        public next60PlusDaysCount: number
    ) {
    }
}
