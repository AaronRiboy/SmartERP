
namespace SmartERP.LeadSourceDB {

    @Serenity.Decorators.registerClass()
    export class LeadSourceDialog extends Serenity.EntityDialog<LeadSourceRow, any> {
        protected getFormKey() { return LeadSourceForm.formKey; }
        protected getIdProperty() { return LeadSourceRow.idProperty; }
        protected getLocalTextPrefix() { return LeadSourceRow.localTextPrefix; }
        protected getNameProperty() { return LeadSourceRow.nameProperty; }
        protected getService() { return LeadSourceService.baseUrl; }
        protected getDeletePermission() { return LeadSourceRow.deletePermission; }
        protected getInsertPermission() { return LeadSourceRow.insertPermission; }
        protected getUpdatePermission() { return LeadSourceRow.updatePermission; }

        protected form = new LeadSourceForm(this.idPrefix);

    }
}