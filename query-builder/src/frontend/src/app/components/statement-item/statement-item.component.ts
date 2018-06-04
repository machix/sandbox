import { Component, OnInit, Input, ViewChild, EventEmitter, Output } from '@angular/core';

/**
 * This class represents the lazy loaded StatementItemComponent.
 */
@Component({
  selector: 'app-sd-statement-item',
  templateUrl: 'statement-item.component.html',
  styleUrls: ['statement-item.component.scss']
})
export class StatementItemComponent implements OnInit {
  @Input() tabShowSetting: any[];
  @Input() termsList: any[];
  @Input() statementsIndex = 0;

  deleteTermIndex = 0;

  @Output() clickDeleteTerm: EventEmitter<string> = new EventEmitter();

  /**
   * OnInit
   */
  ngOnInit() {
  }

  // click Add Term
  addTerm() {
    this.termsList.push({
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
    });
  }

  // click Delete Term
  deleteTerm(index) {
    this.deleteTermIndex = index;
    this.clickDeleteTerm.emit();
  }

  // click Delete Term
  confirmDeleteTerm() {
    this.termsList.splice(this.deleteTermIndex, 1);
  }
}
