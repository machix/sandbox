import { ListOverviewsRequest } from './list-overviews-request';
import { ListOverview } from './list-overview';
import { Overviews } from '../../../../common/models/overviews/overviews';

export class ListOverviews extends Overviews<ListOverviewsRequest, ListOverview> {
    constructor(
      public request: ListOverviewsRequest,
      public recordsCount: number,
      public overviews: ListOverview[]) {
      super(request, recordsCount, overviews);
    }
}
