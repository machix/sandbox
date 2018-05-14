import { InjectionToken } from '@angular/core';
import { INoRequestListService } from './../../../../common/services/lists/i-no-request-list-service';

// tslint:disable-next-line:no-empty-interface
export interface IRegionsListService extends INoRequestListService {
}

export const IRegionsListServiceToken = new InjectionToken<IRegionsListService>('IRegionsListService');
