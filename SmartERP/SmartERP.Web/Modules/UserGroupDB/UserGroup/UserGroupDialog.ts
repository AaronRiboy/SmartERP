
namespace SmartERP.UserGroupDB {

    @Serenity.Decorators.registerClass()
    export class UserGroupDialog extends Serenity.EntityDialog<UserGroupRow, any> {
        protected getFormKey() { return UserGroupForm.formKey; }
        protected getIdProperty() { return UserGroupRow.idProperty; }
        protected getLocalTextPrefix() { return UserGroupRow.localTextPrefix; }
        protected getNameProperty() { return UserGroupRow.nameProperty; }
        protected getService() { return UserGroupService.baseUrl; }
        protected getDeletePermission() { return UserGroupRow.deletePermission; }
        protected getInsertPermission() { return UserGroupRow.insertPermission; }
        protected getUpdatePermission() { return UserGroupRow.updatePermission; }

        protected form = new UserGroupForm(this.idPrefix);

    }
}