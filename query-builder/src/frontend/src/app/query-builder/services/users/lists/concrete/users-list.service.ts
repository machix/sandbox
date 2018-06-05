import { Injectable, Inject } from '@angular/core';
import { NoRequestListService } from '../../../../../common/services/lists/concrete/no-request-list.service';
import { IConfigServiceToken, IConfigService } from '../../../../../common/services/config/i-config-service';
import { IUsersListService } from '../i-users-list.service';

@Injectable()
export class UsersListService
  extends NoRequestListService
  implements IUsersListService {

  constructor(
    @Inject(IConfigServiceToken) private configService: IConfigService) {
    super();
  }

  protected getBaseUrl(): string {
    return this.configService.getApiBaseUrl() + 'users/list';
  }
}
