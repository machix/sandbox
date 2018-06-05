import { OverviewsRequest } from '../../../../common/models/overviews/overviews-request';

export class ListOverviewsRequest extends OverviewsRequest {
    constructor (
        public searchText: string,
        public lastModifiedBy: number[],
        public lastModifiedStart: Date,
        public lastModifiedEnd: Date,
        public sortBy: string,
        public desc: boolean,
        public pageSize: number,
        public pageNumber: number) {
      super(sortBy, desc, pageSize, pageNumber);
    }
}
