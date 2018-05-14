import { EmptyListRequest } from './../../../../common/models/lists/empty-list-request';
import { ICompaniesListServiceToken, ICompaniesListService } from './../../../services/companies/lists/i-companies-list.service';
import { IProcessServiceToken, IProcessService } from './../../../../common/services/process/i-process-service';
import { ModelsList } from './../../../../common/models/lists/models-list';
import { NoRequestModelsList } from './../../../../common/models/lists/no-request-models-list';
import { Component, OnInit, Inject } from '@angular/core';
import { OverviewsFilter } from '../../../../common/components/overviews/overviews-filter.component';
import { ScheduleOverviewsRequest } from '../../../models/schedules/overviews/schedule-overviews-request';
import { IRegionsListServiceToken, IRegionsListService } from '../../../services/regions/lists/i-regions-list.service';
import { Task } from '../../../../common/tasks/task';
import { forkJoin } from 'rxjs/observable/forkJoin';

@Component({
  selector: 'app-schedules-filter',
  templateUrl: './schedules-filter.component.html',
  styles: []
})
export class SchedulesFilterComponent
  extends OverviewsFilter<ScheduleOverviewsRequest> implements OnInit {

  private regionsList: NoRequestModelsList;
  private companiesList: NoRequestModelsList;

  constructor(
    @Inject(IProcessServiceToken) protected processService: IProcessService,
    @Inject(ICompaniesListServiceToken) private companiesService: ICompaniesListService,
    @Inject(IRegionsListServiceToken) private regionsService: IRegionsListService) {
    super(processService);
   }

  public ngOnInit(): void {
    const regionsRequest = this.regionsService.getList(new EmptyListRequest())
                                              .asObservable();

    const companiesRequest = this.companiesService.getList(new EmptyListRequest())
                                                .asObservable();

    Task.create(forkJoin([regionsRequest, companiesRequest]))
      .exec(
      ([regionsList, companiesList]: [NoRequestModelsList, NoRequestModelsList]) => {
        this.regionsList = regionsList;
        this.companiesList = companiesList;
      });
  }
}

