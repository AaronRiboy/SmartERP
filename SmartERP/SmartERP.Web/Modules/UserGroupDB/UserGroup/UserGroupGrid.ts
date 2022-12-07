
namespace SmartERP.UserGroupDB {

    @Serenity.Decorators.registerClass()
    export class UserGroupGrid extends Serenity.EntityGrid<UserGroupRow, any> {
        protected getColumnsKey() { return UserGroupColumns.columnsKey; }
        protected getDialogType() { return UserGroupDialog; }
        protected getIdProperty() { return UserGroupRow.idProperty; }
        protected getInsertPermission() { return UserGroupRow.insertPermission; }
        protected getLocalTextPrefix() { return UserGroupRow.localTextPrefix; }
        protected getService() { return UserGroupService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}