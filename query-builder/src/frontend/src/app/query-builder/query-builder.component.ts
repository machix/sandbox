import { UsersListService } from './services/users/lists/concrete/users-list.service';
import { IUsersListServiceToken } from './services/users/lists/i-users-list.service';
import { ListOverviewsService } from './services/lists/overviews/concrete/list-overviews.service';
import { IListOverviewsServiceToken } from './services/lists/overviews/i-list-overviews.service';
import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';

@Component({
  selector: 'app-query-builder',
  templateUrl: './query-builder.component.html',
  styleUrls: ['./query-builder.component.scss'],
  providers: [
    { provide: IListOverviewsServiceToken, useClass: ListOverviewsService },
    { provide: IUsersListServiceToken, useClass: UsersListService }
  ]
})
export class QueryBuilderComponent implements OnInit {
  constructor(private router: Router) {}

  ngOnInit() {
    // scroll to top when changing route
    this.router.events.subscribe((evt) => {
      if (!(evt instanceof NavigationEnd)) {
        return;
      }

      window.scrollTo(0, 0);
    });
  }
}
