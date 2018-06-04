import { Component, HostListener, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';

import { DataListService } from '../../shared/data-list/data-list.service';

/**
 * This class represents the lazy loaded DashboardPageComponent.
 */
@Component({
  selector: 'app-sd-dashboard-page',
  templateUrl: 'dashboard-page.component.html',
  styleUrls: ['dashboard-page.component.scss']
})
export class DashboardPageComponent implements OnInit {
  errorMessage: string;
  dataList: any[] = [];

  showRightPanel = {
    isShown: false
  };

  showResultTab = false;

  /**
   * Creates an instance of the DashboardPageComponent with the injected
   * NameListService.
   *
   * @param {DataListService} dataListService - The injected DataListService.
   */
  constructor(public dataListService: DataListService,
              private router: Router) {}

  /**
   * OnInit
   */
  ngOnInit() {
    this.getDataList('../../assets/data/dataDashboard.json');
  }

  initData() {
  }

  // click Result Page
  clickResultPage() {
    if (this.showResultTab) {
      this.router.navigate(['/result-page']);
    }
  }

  /**
   * Handle the dataListService observable
   */
  getDataList(jsonUrl) {
    this.dataListService.get(jsonUrl)
      .subscribe(
        dataList => this.dataList = dataList,
        error => this.errorMessage = <any>error,
        () => this.initData()
      );
  }
}
