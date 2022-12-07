
namespace SmartERP.BusnessNatureGrpDB {

    @Serenity.Decorators.registerClass()
    export class BusinessNatureGrpGrid extends Serenity.EntityGrid<BusinessNatureGrpRow, any> {
        protected getColumnsKey() { return BusinessNatureGrpColumns.columnsKey; }
        protected getDialogType() { return BusinessNatureGrpDialog; }
        protected getIdProperty() { return BusinessNatureGrpRow.idProperty; }
        protected getInsertPermission() { return BusinessNatureGrpRow.insertPermission; }
        protected getLocalTextPrefix() { return BusinessNatureGrpRow.localTextPrefix; }
        protected getService() { return BusinessNatureGrpService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}