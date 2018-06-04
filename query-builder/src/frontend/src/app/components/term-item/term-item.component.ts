import { Component, OnInit, Input, ViewChild, EventEmitter, Output } from '@angular/core';
import introJs from 'intro.js/intro.js';

/**
 * This class represents the lazy loaded TermItemComponent.
 */
@Component({
  selector: 'app-sd-term-item',
  templateUrl: 'term-item.component.html',
  styleUrls: ['term-item.component.scss']
})
export class TermItemComponent implements OnInit {
  @Input() tabShowSetting: any[];
  @Input() totalTermNumber = 1;
  @Input() termsList: any[];
  @Input() statementsIndex = 0;
  @Input() termIndex = 0;

  @Output() deleteTerm: EventEmitter<string> = new EventEmitter();

  searchType = 'Explicit';
  inputTypeDropdownValue = 'Select';
  inputTypeSecondDropdownValue = 'Select';
  hierarchyTypeDropdownValue = 'Select';
  functionDropdownValue = 'Select';
  levelsTypeDropdownOption = 'Full';
  levelsTypeDropdownRadio = 'Up';
  limitInputValue = '99';
  limitInputError = false;

  textareaValue = '';
  showTextarea = false;

  subDropdownType = '';
  valueDropdownType = 'list';

  listViewSelectedNumber = 0;
  treeViewSelectedNumber = 0;

  searchImplicitSetting = {
    'typeOptionList': [
    ],
    'showLevelNumber': false
  };

  /**
   * OnInit
   */
  ngOnInit() {
    if (window['tourHasShown']) {
    } else {
      window['tourHasShown'] = true;
      this.startTour();
    }
  }

  startTour() {
    introJs.introJs().setOptions({
    skipLabel: 'Finish',
    doneLabel: 'Finish',
    hidePrev: true,
    hideNext: true,
    showStepNumbers: false,
    showBullets: true,
    overlayOpacity: 0.7,
    disableInteraction: true,
    steps:  [
              {
                element: '#tipStep1',
                intro: 'Welcome, currently you are in Dashboar page.',
                position: 'bottom'
              },
              {
                element: '#tipStep2',
                intro: 'On this page you can manage the custom scripts using lists.<br/>\
                        You can add new, view, edit and delete the lists.',
                position: 'bottom'
              },
              {
                element: '#tipStep3',
                intro: 'On this page you can manage the your saved queries.<br>\
                        You can view, edit and delete the queries.',
                position: 'bottom'
              },
              {
                element: '#tipStep4',
                intro: 'This panel is called "QUERY BUILDER". \                        There are 9 (nine) pre-defined queries for you to choose.<br>\                        They are not totally fixed as parameters, but have some degree of flexibility.',
                position: 'right'
              },
              {
                element: '#tipStep5',
                intro: 'Click this action button to load available queries.',
                position: 'bottom'
              },
              {
                element: '#tipStep6',
                intro: 'This is the query area where you need to enter several requirements.',
                position: 'top'
              },
              {
                element: '#tipStep7',
                intro: 'Clicking this button will add a Statement.',
                position: 'bottom'
              },
              {
                element: '#tipStep8',
                intro: 'Clicking this action link will add a Term for each Statement.',
                position: 'bottom'
              },
              {
                element: '#tipStep9',
                intro: 'Once you submit your custom parameters, the Query Results will be \
                        presented on "RESULTS" tab above.',
                position: 'bottom'
              },
              {
                element: '#tipStep10',
                intro: 'Click this action link to open "This Session\'s Query Queu" window',
                position: 'bottom'
              },
              {
                element: '#tipStep11',
                intro: 'Within the "RESULTS" tab, you will see the results for the \                        multiple query names that you have submitted in tabulated format.',
                position: 'bottom'
              }
            ]
    }).start();
  }

  // click on color bar of Search Type
  toggleSearchType() {
    if (this.searchType === 'Explicit') {
      this.searchType = 'Implicit';
    } else {
      this.searchType = 'Explicit';
    }
  }

  // change Input Type dropdown
  changeInputType(item) {
    this.subDropdownType = item['subDropdownType'];
    this.searchImplicitSetting = item['searchImplicitSetting'];
    this.valueDropdownType = item['valueDropdownType'];

    this.levelsTypeDropdownOption = 'Full';
    this.levelsTypeDropdownRadio = 'Up';

    this.termsList[this.termIndex]['showTreeView'] = false;

    this.checkOnTree();
  }

  // click Tree icon
  clickTreeIcon() {
    if (this.termsList[this.termIndex]['showTreeView']) {
      this.termsList.forEach(function(item, index) {
        item['showTreeView'] = false;
      });
      this.termsList[this.termIndex]['showTreeView'] = false;
    } else {
      this.termsList.forEach(function(item, index) {
        item['showTreeView'] = false;
      });
      this.termsList[this.termIndex]['showTreeView'] = true;
    }
  }

  // check/uncheck parent item
  checkParentItem(parentItem) {
    if (parentItem['checked']) {
      parentItem['level1Data'].forEach(function(level1Item, level1Index) {
        level1Item['checked'] = true;
        level1Item['level2Data'].forEach(function(level2Item, level2Index) {
          level2Item['checked'] = true;
        });
      });
    } else {
      parentItem['level1Data'].forEach(function(level1Item, level1Index) {
        level1Item['checked'] = false;
        level1Item['level2Data'].forEach(function(level2Item, level2Index) {
          level2Item['checked'] = false;
        });
      });
    }
  }

  // check/uncheck level1 item
  checkLevel1Item(level1Item) {
    if (level1Item['checked']) {
      level1Item['level2Data'].forEach(function(level2Item, index) {
        level2Item['checked'] = true;
      });
    } else {
      level1Item['level2Data'].forEach(function(level2Item, index) {
        level2Item['checked'] = false;
      });
    }
  }

  // click Delete Term
  clickDeleteTerm() {
    this.deleteTerm.emit(this.termIndex.toString());
  }

  // check on list view
  checkOnList() {
    let number = 0;

    this.termsList[this.termIndex]['listViewData'].forEach(function(item, index) {
      if (item['checked']) {
        number++;
      }
    });

    this.listViewSelectedNumber = number;
  }

  // check on tree view
  checkOnTree() {
    let number = 0;
    const valueDropdownType = this.valueDropdownType;

    this.termsList[this.termIndex]['treeViewData'].forEach(function(parentItem, index) {
      if (parentItem['checked']) {
        number++;
      }
      parentItem['level1Data'].forEach(function(level1Item, level1Index) {
        if (level1Item['checked']) {
          number++;
        }
        if (valueDropdownType === 'tree-level-2') {
          level1Item['level2Data'].forEach(function(level2Item, level2Index) {
            if (level2Item['checked']) {
              number++;
            }
          });
        }
      });
    });

    this.treeViewSelectedNumber = number;
  }

  // change input value
  onChangeInput() {
    if (this.limitInputValue === '') {
      this.limitInputError = true;
      return;
    }

    const reg = /^[1-9]\d*$|^0$/;
    if (reg.test(this.limitInputValue)) {
      const value = parseInt(this.limitInputValue, 10);
      if ((value > 0) && (value < 100)) {
        this.limitInputError = false;
      } else {
        this.limitInputError = true;
      }
    } else {
      this.limitInputError = true;
    }
  }
}
