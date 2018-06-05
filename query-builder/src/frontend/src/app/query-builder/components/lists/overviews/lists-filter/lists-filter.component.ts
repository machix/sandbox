import { Task } from './../../../../../common/tasks/task';
import { EmptyListRequest } from './../../../../../common/models/lists/empty-list-request';
import { IUsersListServiceToken, IUsersListService } from './../../../../services/users/lists/i-users-list.service';
import { IProcessServiceToken, IProcessService } from './../../../../../common/services/process/i-process-service';
import { NoRequestModelsList } from './../../../../../common/models/lists/no-request-models-list';
import { ListOverviewsRequest } from './../../../../models/lists/overviews/list-overviews-request';
import { Component, OnInit, Inject } from '@angular/core';
import { forkJoin } from 'rxjs/observable/forkJoin';
import { OverviewsFilter } from '../../../../../common/components/overviews/overviews-filter.component';

@Component({
  selector: 'app-lists-filter',
  templateUrl: './lists-filter.component.html',
  styles: []
})
export class ListsFilterComponent
  extends OverviewsFilter<ListOverviewsRequest> implements OnInit {

  public usersList: NoRequestModelsList;

  constructor(
    @Inject(IProcessServiceToken) protected processService: IProcessService,
    @Inject(IUsersListServiceToken) private usersService: IUsersListService) {
    super(processService);
   }

  public ngOnInit(): void {

    const usersRequest = this.usersService.getList(new EmptyListRequest())                                                .asObservable();

    Task.create(forkJoin([usersRequest]))
      .exec(
      ([usersList]: [NoRequestModelsList]) => {
        this.usersList = usersList;
      });
  }
}
