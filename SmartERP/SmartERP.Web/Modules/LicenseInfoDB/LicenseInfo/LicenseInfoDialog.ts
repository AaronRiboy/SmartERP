
namespace SmartERP.LicenseInfoDB {

    @Serenity.Decorators.registerClass()
    export class LicenseInfoDialog extends Serenity.EntityDialog<LicenseInfoRow, any> {
        protected getFormKey() { return LicenseInfoForm.formKey; }
        protected getIdProperty() { return LicenseInfoRow.idProperty; }
        protected getLocalTextPrefix() { return LicenseInfoRow.localTextPrefix; }
        protected getNameProperty() { return LicenseInfoRow.nameProperty; }
        protected getService() { return LicenseInfoService.baseUrl; }
        protected getDeletePermission() { return LicenseInfoRow.deletePermission; }
        protected getInsertPermission() { return LicenseInfoRow.insertPermission; }
        protected getUpdatePermission() { return LicenseInfoRow.updatePermission; }

        protected form = new LicenseInfoForm(this.idPrefix);

    }
}