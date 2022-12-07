
namespace SmartERP.BusinessNatureDB {

    @Serenity.Decorators.registerClass()
    export class BusinessNatureDialog extends Serenity.EntityDialog<BusinessNatureRow, any> {
        protected getFormKey() { return BusinessNatureForm.formKey; }
        protected getIdProperty() { return BusinessNatureRow.idProperty; }
        protected getLocalTextPrefix() { return BusinessNatureRow.localTextPrefix; }
        protected getNameProperty() { return BusinessNatureRow.nameProperty; }
        protected getService() { return BusinessNatureService.baseUrl; }
        protected getDeletePermission() { return BusinessNatureRow.deletePermission; }
        protected getInsertPermission() { return BusinessNatureRow.insertPermission; }
        protected getUpdatePermission() { return BusinessNatureRow.updatePermission; }

        protected form = new BusinessNatureForm(this.idPrefix);

    }
}