
namespace SmartERP.SalesPersonDB {

    @Serenity.Decorators.registerClass()
    export class SalesPersonDialog extends Serenity.EntityDialog<SalesPersonRow, any> {
        protected getFormKey() { return SalesPersonForm.formKey; }
        protected getIdProperty() { return SalesPersonRow.idProperty; }
        protected getLocalTextPrefix() { return SalesPersonRow.localTextPrefix; }
        protected getNameProperty() { return SalesPersonRow.nameProperty; }
        protected getService() { return SalesPersonService.baseUrl; }
        protected getDeletePermission() { return SalesPersonRow.deletePermission; }
        protected getInsertPermission() { return SalesPersonRow.insertPermission; }
        protected getUpdatePermission() { return SalesPersonRow.updatePermission; }

        protected form = new SalesPersonForm(this.idPrefix);

    }
}