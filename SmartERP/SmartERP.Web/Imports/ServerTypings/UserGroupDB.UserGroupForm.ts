namespace SmartERP.UserGroupDB {
    export interface UserGroupForm {
        AcUserGroupDesc: Serenity.StringEditor;
        IsSmartStaff: Serenity.StringEditor;
        CreateBy: Serenity.StringEditor;
        CreateDate: Serenity.DateEditor;
        EditBy: Serenity.StringEditor;
        EditDate: Serenity.DateEditor;
    }

    export class UserGroupForm extends Serenity.PrefixedContext {
        static formKey = 'UserGroupDB.UserGroup';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserGroupForm.init)  {
                UserGroupForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;

                Q.initFormType(UserGroupForm, [
                    'AcUserGroupDesc', w0,
                    'IsSmartStaff', w0,
                    'CreateBy', w0,
                    'CreateDate', w1,
                    'EditBy', w0,
                    'EditDate', w1
                ]);
            }
        }
    }
}
