namespace SmartERP.UserDB {
    export interface UserForm {
        DealerId: Serenity.StringEditor;
        MasterDealer: Serenity.StringEditor;
        AcUserGroupId: Serenity.StringEditor;
        PwdLogin: Serenity.StringEditor;
        Active: Serenity.StringEditor;
        Remark: Serenity.StringEditor;
        CreateBy: Serenity.StringEditor;
        CreateDate: Serenity.DateEditor;
        EditBy: Serenity.StringEditor;
        EditDate: Serenity.DateEditor;
        Stamp: Serenity.IntegerEditor;
        IsTaxExclusive: Serenity.StringEditor;
    }

    export class UserForm extends Serenity.PrefixedContext {
        static formKey = 'UserDB.User';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserForm.init)  {
                UserForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(UserForm, [
                    'DealerId', w0,
                    'MasterDealer', w0,
                    'AcUserGroupId', w0,
                    'PwdLogin', w0,
                    'Active', w0,
                    'Remark', w0,
                    'CreateBy', w0,
                    'CreateDate', w1,
                    'EditBy', w0,
                    'EditDate', w1,
                    'Stamp', w2,
                    'IsTaxExclusive', w0
                ]);
            }
        }
    }
}
