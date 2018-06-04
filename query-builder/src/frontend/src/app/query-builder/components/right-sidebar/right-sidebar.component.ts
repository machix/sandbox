import { Component, OnInit, Input, ViewChild } from '@angular/core';

/**
 * This class represents the lazy loaded RightSidebarComponent.
 */
@Component({
  selector: 'app-sd-right-sidebar',
  templateUrl: 'right-sidebar.component.html',
  styleUrls: ['right-sidebar.component.scss']
})
export class RightSidebarComponent {
  @Input() showRightPanel: any[];
  tabIndex = 0;
}
