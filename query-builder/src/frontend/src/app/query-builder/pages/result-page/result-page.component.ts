import { Component, HostListener, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { DataListService } from '../../shared/data-list/data-list.service';

/**
 * This class represents the lazy loaded ResultPageComponent.
 */
@Component({
  selector: 'app-sd-result-page',
  templateUrl: 'result-page.component.html',
  styleUrls: ['result-page.component.scss']
})
export class ResultPageComponent implements OnInit {
  errorMessage: string;
  dataList: any[] = [];

  showRightPanel = {
    isShown: false
  };

  scrollbarOptions = {
    axis: 'yx',
    theme: 'minimal-dark'
  };

  totalLength = 0;
  activeIndex = 0;

  /**
   * Creates an instance of the ResultPageComponent with the injected
   * NameListService.
   *
   * @param {DataListService} dataListService - The injected DataListService.
   */
  constructor(public dataListService: DataListService) {}

  /**
   * OnInit
   */
  ngOnInit() {
    this.getDataList('../../assets/data/dataResult.json');
  }

  initData() {
    this.totalLength = this.dataList['queryResultList'].length;
  }

  // click Statement tab
  clickQueryResultTab(index) {
    this.activeIndex = index;
  }

  // click prev button
  clickPrev() {
    if (this.activeIndex > 0) {
      this.activeIndex--;
    }
  }

  // click next button
  clickNext() {
    if (this.activeIndex < this.dataList['queryResultList'].length - 1) {
      this.activeIndex++;
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
