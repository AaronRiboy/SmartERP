
namespace SmartERP.LeadStatusDB {

    @Serenity.Decorators.registerClass()
    export class LeadStatusGrid extends Serenity.EntityGrid<LeadStatusRow, any> {
        protected getColumnsKey() { return LeadStatusColumns.columnsKey; }
        protected getDialogType() { return LeadStatusDialog; }
        protected getIdProperty() { return LeadStatusRow.idProperty; }
        protected getInsertPermission() { return LeadStatusRow.insertPermission; }
        protected getLocalTextPrefix() { return LeadStatusRow.localTextPrefix; }
        protected getService() { return LeadStatusService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}