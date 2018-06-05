import { NumberIdBusinessModel } from '../../../../common/models/entity/number-id-business-model';

export class ListOverview extends NumberIdBusinessModel {
    constructor(
        public id: number,
        public name: string,
        public numberOfScripts: number,
        public lastModifiedBy: string,
        public lastModified: Date
    ) {
        super(id);
    }
}
