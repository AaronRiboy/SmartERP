
namespace SmartERP.SalesPersonDB {

    @Serenity.Decorators.registerClass()
    export class SalesPersonGrid extends Serenity.EntityGrid<SalesPersonRow, any> {
        protected getColumnsKey() { return SalesPersonColumns.columnsKey; }
        protected getDialogType() { return SalesPersonDialog; }
        protected getIdProperty() { return SalesPersonRow.idProperty; }
        protected getInsertPermission() { return SalesPersonRow.insertPermission; }
        protected getLocalTextPrefix() { return SalesPersonRow.localTextPrefix; }
        protected getService() { return SalesPersonService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}