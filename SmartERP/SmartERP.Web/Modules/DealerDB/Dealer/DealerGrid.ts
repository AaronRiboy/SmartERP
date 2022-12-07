
namespace SmartERP.DealerDB {

    @Serenity.Decorators.registerClass()
    export class DealerGrid extends Serenity.EntityGrid<DealerRow, any> {
        protected getColumnsKey() { return DealerColumns.columnsKey; }
        protected getDialogType() { return DealerDialog; }
        protected getIdProperty() { return DealerRow.idProperty; }
        protected getInsertPermission() { return DealerRow.insertPermission; }
        protected getLocalTextPrefix() { return DealerRow.localTextPrefix; }
        protected getService() { return DealerService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}