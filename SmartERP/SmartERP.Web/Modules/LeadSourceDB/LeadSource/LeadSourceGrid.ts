
namespace SmartERP.LeadSourceDB {

    @Serenity.Decorators.registerClass()
    export class LeadSourceGrid extends Serenity.EntityGrid<LeadSourceRow, any> {
        protected getColumnsKey() { return LeadSourceColumns.columnsKey; }
        protected getDialogType() { return LeadSourceDialog; }
        protected getIdProperty() { return LeadSourceRow.idProperty; }
        protected getInsertPermission() { return LeadSourceRow.insertPermission; }
        protected getLocalTextPrefix() { return LeadSourceRow.localTextPrefix; }
        protected getService() { return LeadSourceService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}