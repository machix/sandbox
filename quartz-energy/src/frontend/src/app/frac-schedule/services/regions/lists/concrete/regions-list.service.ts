import { IRegionsListService } from './../i-regions-list.service';
import { Injectable, Inject } from '@angular/core';
import { NoRequestListService } from '../../../../../common/services/lists/concrete/no-request-list.service';
import { IConfigServiceToken, IConfigService } from '../../../../../common/services/config/i-config-service';

@Injectable()
export class RegionsListService
  extends NoRequestListService
  implements IRegionsListService {

  constructor(
    @Inject(IConfigServiceToken) private configService: IConfigService) {
    super();
  }

  protected getBaseUrl(): string {
    return this.configService.getApiBaseUrl() + 'regions/list';
  }
}
