import { Component, OnInit } from '@angular/core';
import { OverviewComponent } from '../../../../../common/components/overviews/overview.component';
import { ListOverview } from '../../../../models/lists/overviews/list-overview';

@Component({
  selector: 'app-list-overview',
  templateUrl: './list-overview.component.html',
  styles: []
})
export class ListOverviewComponent extends OverviewComponent<ListOverview>
  implements OnInit {

  constructor() {
    super();
  }

  ngOnInit() {
  }

}
