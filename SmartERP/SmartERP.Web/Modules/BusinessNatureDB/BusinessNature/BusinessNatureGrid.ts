
namespace SmartERP.BusinessNatureDB {

    @Serenity.Decorators.registerClass()
    export class BusinessNatureGrid extends Serenity.EntityGrid<BusinessNatureRow, any> {
        protected getColumnsKey() { return BusinessNatureColumns.columnsKey; }
        protected getDialogType() { return BusinessNatureDialog; }
        protected getIdProperty() { return BusinessNatureRow.idProperty; }
        protected getInsertPermission() { return BusinessNatureRow.insertPermission; }
        protected getLocalTextPrefix() { return BusinessNatureRow.localTextPrefix; }
        protected getService() { return BusinessNatureService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}