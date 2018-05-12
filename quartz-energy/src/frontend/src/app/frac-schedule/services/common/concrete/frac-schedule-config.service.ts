import { environment } from './../../../../../environments/environment';
import { IConfigService } from './../../../../common/services/config/i-config-service';
import { Injectable } from '@angular/core';
@Injectable()
export class FracScheduleConfigService implements IConfigService {

  getApiBaseUrl(): string {
    return environment.API_BASE_URL;
  }

  getPageSize(): number {
    return environment.PAGE_SIZE;
  }
}
