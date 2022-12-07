
namespace SmartERP.CompanyGroupDB {

    @Serenity.Decorators.registerClass()
    export class CompanyGroupDialog extends Serenity.EntityDialog<CompanyGroupRow, any> {
        protected getFormKey() { return CompanyGroupForm.formKey; }
        protected getIdProperty() { return CompanyGroupRow.idProperty; }
        protected getLocalTextPrefix() { return CompanyGroupRow.localTextPrefix; }
        protected getNameProperty() { return CompanyGroupRow.nameProperty; }
        protected getService() { return CompanyGroupService.baseUrl; }
        protected getDeletePermission() { return CompanyGroupRow.deletePermission; }
        protected getInsertPermission() { return CompanyGroupRow.insertPermission; }
        protected getUpdatePermission() { return CompanyGroupRow.updatePermission; }

        protected form = new CompanyGroupForm(this.idPrefix);

    }
}