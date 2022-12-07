
namespace SmartERP.CustomerStatusDB {

    @Serenity.Decorators.registerClass()
    export class CustomerStatusDialog extends Serenity.EntityDialog<CustomerStatusRow, any> {
        protected getFormKey() { return CustomerStatusForm.formKey; }
        protected getIdProperty() { return CustomerStatusRow.idProperty; }
        protected getLocalTextPrefix() { return CustomerStatusRow.localTextPrefix; }
        protected getNameProperty() { return CustomerStatusRow.nameProperty; }
        protected getService() { return CustomerStatusService.baseUrl; }
        protected getDeletePermission() { return CustomerStatusRow.deletePermission; }
        protected getInsertPermission() { return CustomerStatusRow.insertPermission; }
        protected getUpdatePermission() { return CustomerStatusRow.updatePermission; }

        protected form = new CustomerStatusForm(this.idPrefix);

    }
}