
namespace SmartERP.CustomerStatusDB {

    @Serenity.Decorators.registerClass()
    export class CustomerStatusGrid extends Serenity.EntityGrid<CustomerStatusRow, any> {
        protected getColumnsKey() { return CustomerStatusColumns.columnsKey; }
        protected getDialogType() { return CustomerStatusDialog; }
        protected getIdProperty() { return CustomerStatusRow.idProperty; }
        protected getInsertPermission() { return CustomerStatusRow.insertPermission; }
        protected getLocalTextPrefix() { return CustomerStatusRow.localTextPrefix; }
        protected getService() { return CustomerStatusService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}