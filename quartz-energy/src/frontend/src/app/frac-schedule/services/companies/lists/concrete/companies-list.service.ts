import { IConfigServiceToken, IConfigService } from './../../../../../common/services/config/i-config-service';
import { ICompaniesListService } from './../i-companies-list.service';
import { Injectable, Inject } from '@angular/core';
import { NoRequestListService } from '../../../../../common/services/lists/concrete/no-request-list.service';

@Injectable()
export class CompaniesListService
  extends NoRequestListService
  implements ICompaniesListService {

  constructor(
    @Inject(IConfigServiceToken) private configService: IConfigService) {
    super();
  }

  protected getBaseUrl(): string {
    return this.configService.getApiBaseUrl() + 'companies/list';
  }
}
