
namespace SmartERP.UserDB {

    @Serenity.Decorators.registerClass()
    export class UserDialog extends Serenity.EntityDialog<UserRow, any> {
        protected getFormKey() { return UserForm.formKey; }
        protected getIdProperty() { return UserRow.idProperty; }
        protected getLocalTextPrefix() { return UserRow.localTextPrefix; }
        protected getNameProperty() { return UserRow.nameProperty; }
        protected getService() { return UserService.baseUrl; }
        protected getDeletePermission() { return UserRow.deletePermission; }
        protected getInsertPermission() { return UserRow.insertPermission; }
        protected getUpdatePermission() { return UserRow.updatePermission; }

        protected form = new UserForm(this.idPrefix);

    }
}