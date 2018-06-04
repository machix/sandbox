import { Component, OnInit, Input, ViewChild } from '@angular/core';

/**
 * This class represents the lazy loaded ResultTableComponent.
 */
@Component({
  selector: 'app-sd-result-table',
  templateUrl: 'result-table.component.html',
  styleUrls: ['result-table.component.scss']
})
export class ResultTableComponent {
  @Input() dataList: any[];
  paginationDropdownValue = '10';
  columnNumber = 7;

  syntaxContent = 'SELECT DISTINCT r.report_name, v.attribute_value, vt.value_type<br/>\
    FROM mlreportdefinition r<br/>\
    JOIN MRLDEFINITIONCONTAINER dct ON r-report_definition_id = dct.report_definition_id<br/>\
    JOIN MRLDEFINITIONCONTAINERMAP cm ON dct.container_id = cm.container_id<br/>\
    JOIN MRLCOONTAINERTYPE ct ON dct.container_type = ct.type_id<br/>\
    LEFT JOIN mrlattributevaluegroup ag ON cm.attribute_group_id = ag.attribute_group_id<br/>\
    LEFT JOIN MRLATTRIBUTEVALUE v ON ag.attribute_value_id = v.attribute_value_id<br/>\
    LEFT join mrlattributevaluetype vt ON ag.attribute_value_type = vt.value_type_id<br/>\
    WHERE r.closed_date IS NULL<br/>\
        AND sysdate >= r.begin_cob_date<br/>\
        AND sysdate < r.end_cob_date<br/>\
        and v.attribute_value IN (\'IRVEGA\',\'IRNORMALVEGA\')<br/>\
    UNION';

  scrollbarOptions = {
    axis: 'yx',
    theme: 'minimal-dark'
  };

  // copy Syntax
  copySyntax() {
  }
}
