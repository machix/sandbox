import { Component, OnInit, Input, ViewChild } from '@angular/core';

/**
 * This class represents the lazy loaded LeftSidebarComponent.
 */
@Component({
  selector: 'app-sd-left-sidebar',
  templateUrl: 'left-sidebar.component.html',
  styleUrls: ['left-sidebar.component.scss']
})
export class LeftSidebarComponent {
  @Input() dataList: any[];

  // click on nav
  clickNav(subTabName) {
    let tabIndex = 0;
    this.dataList['subTabList'].forEach(function(item, index) {
      if (item['tabName'] === subTabName) {
        tabIndex = index;
      }
    });

    this.dataList['subTabActive'] = this.dataList['subTabList'][tabIndex]['tabName'];
    this.dataList['tabShowSetting'] = this.dataList['subTabList'][tabIndex]['tabShowSetting'];
  }
}
