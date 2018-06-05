import { IProcessServiceToken, IProcessService } from './../../../../../common/services/process/i-process-service';
import { Component, Inject } from '@angular/core';
import { MatTableOverviewsComponent } from '../../../../../common/components/overviews/mat-table-overviews.component';
import { IListOverviewsService, IListOverviewsServiceToken } from '../../../../services/lists/overviews/i-list-overviews.service';
import { ListOverviewsRequest } from '../../../../models/lists/overviews/list-overviews-request';
import { ListOverviews } from '../../../../models/lists/overviews/list-overviews';
import { ListOverview } from '../../../../models/lists/overviews/list-overview';
import { IConfigServiceToken, IConfigService } from '../../../../../common/services/config/i-config-service';

@Component({
  selector: 'app-lists',
  templateUrl: './lists.component.html',
  styles: []
})
export class ListsComponent
  extends MatTableOverviewsComponent<IListOverviewsService,
                                      ListOverviewsRequest,
                                      ListOverviews,
                                      ListOverview> {

    public displayedColumns = [
      'name',
      'numberOfScripts',
      'lastModifiedBy',
      'lastModified',
      'actions'];

    constructor(
        @Inject(IProcessServiceToken) protected processService: IProcessService,
        @Inject(IListOverviewsServiceToken) protected overviewsService: IListOverviewsService,
        @Inject(IConfigServiceToken) private configService: IConfigService) {
        super(
          processService,
          overviewsService,
          configService.getPageSize());
    }
}
