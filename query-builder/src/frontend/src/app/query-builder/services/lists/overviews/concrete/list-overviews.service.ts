import { IListOverviewsService } from './../i-list-overviews.service';
import { Injectable, Inject } from '@angular/core';
import { OverviewsService } from '../../../../../common/services/overviews/concrete/overviews.service';
import { ListOverviewsRequest } from '../../../../models/lists/overviews/list-overviews-request';
import { ListOverviews } from '../../../../models/lists/overviews/list-overviews';
import { IConfigServiceToken, IConfigService } from '../../../../../common/services/config/i-config-service';

@Injectable()
export class ListOverviewsService
        extends OverviewsService<ListOverviewsRequest, ListOverviews>
        implements IListOverviewsService {
    constructor (
        @Inject(IConfigServiceToken) private configService: IConfigService) {
        super();
    }

    protected getBaseUrl(): string {
        return this.configService.getApiBaseUrl() + 'lists';
    }
}
