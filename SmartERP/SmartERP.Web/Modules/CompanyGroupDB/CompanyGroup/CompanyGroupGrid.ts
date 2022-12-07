
namespace SmartERP.CompanyGroupDB {

    @Serenity.Decorators.registerClass()
    export class CompanyGroupGrid extends Serenity.EntityGrid<CompanyGroupRow, any> {
        protected getColumnsKey() { return CompanyGroupColumns.columnsKey; }
        protected getDialogType() { return CompanyGroupDialog; }
        protected getIdProperty() { return CompanyGroupRow.idProperty; }
        protected getInsertPermission() { return CompanyGroupRow.insertPermission; }
        protected getLocalTextPrefix() { return CompanyGroupRow.localTextPrefix; }
        protected getService() { return CompanyGroupService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}