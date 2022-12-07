
namespace SmartERP.LicenseInfoDB {

    @Serenity.Decorators.registerClass()
    export class LicenseInfoGrid extends Serenity.EntityGrid<LicenseInfoRow, any> {
        protected getColumnsKey() { return LicenseInfoColumns.columnsKey; }
        protected getDialogType() { return LicenseInfoDialog; }
        protected getIdProperty() { return LicenseInfoRow.idProperty; }
        protected getInsertPermission() { return LicenseInfoRow.insertPermission; }
        protected getLocalTextPrefix() { return LicenseInfoRow.localTextPrefix; }
        protected getService() { return LicenseInfoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}