
namespace SmartERP.LeadStatusDB {

    @Serenity.Decorators.registerClass()
    export class LeadStatusDialog extends Serenity.EntityDialog<LeadStatusRow, any> {
        protected getFormKey() { return LeadStatusForm.formKey; }
        protected getIdProperty() { return LeadStatusRow.idProperty; }
        protected getLocalTextPrefix() { return LeadStatusRow.localTextPrefix; }
        protected getNameProperty() { return LeadStatusRow.nameProperty; }
        protected getService() { return LeadStatusService.baseUrl; }
        protected getDeletePermission() { return LeadStatusRow.deletePermission; }
        protected getInsertPermission() { return LeadStatusRow.insertPermission; }
        protected getUpdatePermission() { return LeadStatusRow.updatePermission; }

        protected form = new LeadStatusForm(this.idPrefix);

    }
}