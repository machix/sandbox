import { InjectionToken } from '@angular/core';
import { IOverviewsService } from '../../../../common/services/overviews/i-overviews.service';
import { ListOverviewsRequest } from '../../../models/lists/overviews/list-overviews-request';
import { ListOverviews } from '../../../models/Lists/overviews/list-overviews';

// tslint:disable-next-line:no-empty-interface
export interface IListOverviewsService
    extends IOverviewsService<ListOverviewsRequest, ListOverviews> {
}

export const IListOverviewsServiceToken = new InjectionToken<IListOverviewsService>('IListOverviewsService');
