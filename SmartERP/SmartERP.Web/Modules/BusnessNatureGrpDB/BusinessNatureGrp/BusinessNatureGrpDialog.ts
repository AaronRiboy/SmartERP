
namespace SmartERP.BusnessNatureGrpDB {

    @Serenity.Decorators.registerClass()
    export class BusinessNatureGrpDialog extends Serenity.EntityDialog<BusinessNatureGrpRow, any> {
        protected getFormKey() { return BusinessNatureGrpForm.formKey; }
        protected getIdProperty() { return BusinessNatureGrpRow.idProperty; }
        protected getLocalTextPrefix() { return BusinessNatureGrpRow.localTextPrefix; }
        protected getNameProperty() { return BusinessNatureGrpRow.nameProperty; }
        protected getService() { return BusinessNatureGrpService.baseUrl; }
        protected getDeletePermission() { return BusinessNatureGrpRow.deletePermission; }
        protected getInsertPermission() { return BusinessNatureGrpRow.insertPermission; }
        protected getUpdatePermission() { return BusinessNatureGrpRow.updatePermission; }

        protected form = new BusinessNatureGrpForm(this.idPrefix);

    }
}