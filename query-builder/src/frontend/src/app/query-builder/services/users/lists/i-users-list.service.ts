import { INoRequestListService } from './../../../../common/services/lists/i-no-request-list-service';
import { InjectionToken } from '@angular/core';

// tslint:disable-next-line:no-empty-interface
export interface IUsersListService extends INoRequestListService {
}

export const IUsersListServiceToken = new InjectionToken<IUsersListService>('IUsersListService');
