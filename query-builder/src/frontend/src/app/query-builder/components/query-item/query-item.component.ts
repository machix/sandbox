import { Component, OnInit, Input, ViewChild } from '@angular/core';

import { ModalWindowsComponent } from '../modal-windows/modal-windows.component';
import { StatementItemComponent } from '../statement-item/statement-item.component';

/**
 * This class represents the lazy loaded QueryItemComponent.
 */
@Component({
  selector: 'app-sd-query-item',
  templateUrl: 'query-item.component.html',
  styleUrls: ['query-item.component.scss']
})
export class QueryItemComponent implements OnInit {
  @Input() subTabActive: string;
  @Input() tabShowSetting: any[];

  scriptListChecked = false;
  scriptListDropdownValue = 'Select';

  additionalBreakDownCheck = false;
  additionalBreakDownList = [
    {
      'dropdownValue': 'Select'
    }
  ];

  statementsList = [
    {
      'name': 'Statement 1',
      'termsList': [
        {
          'showTreeView': false,
          'levelsRadioModel': '',
          'displayByRadioModel': '',
          'listViewData': [
            {
              'name': '2T6',
              'checked': false
            },
            {
              'name': '2T7',
              'checked': false
            },
            {
              'name': '2T7',
              'checked': false
            },
            {
              'name': '2T7',
              'checked': false
            },
            {
              'name': '2T7',
              'checked': false
            },
            {
              'name': '2T7',
              'checked': false
            }
          ],
          'treeViewData': [
            {
              'name': 'One_Bank_DIVHIER',
              'checked': false,
              'expanded': false,
              'level1Data': [
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                }
              ]
            },
            {
              'name': 'One_Bank_DIVHIER',
              'checked': false,
              'expanded': false,
              'level1Data': [
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                }
              ]
            },
            {
              'name': 'One_Bank_DIVHIER',
              'checked': false,
              'expanded': false,
              'level1Data': [
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                }
              ]
            },
            {
              'name': 'One_Bank_DIVHIER',
              'checked': false,
              'expanded': false,
              'level1Data': [
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                }
              ]
            }
          ]
        }
      ]
    }
  ];
  totalLength = 1;
  activeIndex = 0;
  deleteStatementIndex = 0;
  saveQueryEnabled = false;
  model;

  scrollbarOptions = {
    axis: 'yx',
    theme: 'minimal-dark'
  };

  @ViewChild(ModalWindowsComponent) modalWindows: ModalWindowsComponent;
  @ViewChild(StatementItemComponent) statementItem: StatementItemComponent;

  /**
   * OnInit
   */
  ngOnInit() {
  }

  // Load Saved Query
  clickLoadSavedQuery() {
    this.modalWindows.openLoadSavedQueryModal();
    this.saveQueryEnabled = true;
  }

  // Save Query
  clickSaveQuery() {
    this.modalWindows.openSaveQueryModal();
  }

  // click Delete Statement
  clickDeleteStatement(index) {
    this.deleteStatementIndex = index;
    this.modalWindows.openDeleteStatementModal();
  }

  // confirm Delete Statement
  confirmDeleteStatement(event) {
    this.statementsList.splice(this.deleteStatementIndex, 1);
    this.totalLength = this.statementsList.length;
    this.activeIndex = 0;
  }

  // click Delete Term
  clickDeleteTerm(index) {
    this.modalWindows.openDeleteTermModal();
  }

  // confirm Delete Term
  confirmDeleteTerm(event) {
    this.statementItem.confirmDeleteTerm();
  }

  // delete BreakDown item
  deleteBreakDownItem(index) {
    this.additionalBreakDownList.splice(index, 1);
  }

  // add BreakDown item
  addBreakDownItem() {
    this.additionalBreakDownList.push({
      'dropdownValue': 'Select'
    });
  }

  // click Add Statement
  addStatement() {
    const lastItemName = this.statementsList[this.statementsList.length - 1]['name'].replace('Statement ', '');
    const number = parseInt(lastItemName, 10) + 1;

    this.statementsList.push({
      'name': 'Statement ' + number,
      'termsList': [
        {
          'showTreeView': false,
          'levelsRadioModel': '',
          'displayByRadioModel': '',
          'listViewData': [
            {
              'name': '2T7',
              'checked': false
            },
            {
              'name': '2T7',
              'checked': false
            },
            {
              'name': '2T7',
              'checked': false
            },
            {
              'name': '2T7',
              'checked': false
            },
            {
              'name': '2T7',
              'checked': false
            },
            {
              'name': '2T7',
              'checked': false
            }
          ],
          'treeViewData': [
            {
              'name': 'One_Bank_DIVHIER',
              'checked': false,
              'expanded': false,
              'level1Data': [
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                }
              ]
            },
            {
              'name': 'One_Bank_DIVHIER',
              'checked': false,
              'expanded': false,
              'level1Data': [
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                }
              ]
            },
            {
              'name': 'One_Bank_DIVHIER',
              'checked': false,
              'expanded': false,
              'level1Data': [
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                }
              ]
            },
            {
              'name': 'One_Bank_DIVHIER',
              'checked': false,
              'expanded': false,
              'level1Data': [
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                },
                {
                  'name': 'One_Bank_DIVHIER',
                  'checked': false,
                  'level2Data': [
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    },
                    {
                      'name': 'One_Bank_DIVHIER',
                      'checked': false
                    }
                  ]
                }
              ]
            }
          ]
        }
      ]
    });

    this.totalLength = this.statementsList.length;
  }

  // click Statement tab
  clickStatementTab(index) {
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
    if (this.activeIndex < this.statementsList.length - 1) {
      this.activeIndex++;
    }
  }

  // click body
  clickBody() {
    this.statementsList.forEach(function(statementItem, statementIndex) {
      statementItem.termsList.forEach(function(termItem, termIndex) {
        termItem['showTreeView'] = false;
      });
    });
  }
}
