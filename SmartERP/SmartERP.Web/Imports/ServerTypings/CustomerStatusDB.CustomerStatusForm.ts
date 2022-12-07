namespace SmartERP.CustomerStatusDB {
    export interface CustomerStatusForm {
        AcCustomerStatusDesc: Serenity.StringEditor;
        CreateBy: Serenity.StringEditor;
        CreateDate: Serenity.DateEditor;
        EditBy: Serenity.StringEditor;
        EditDate: Serenity.DateEditor;
        Stamp: Serenity.IntegerEditor;
    }

    export class CustomerStatusForm extends Serenity.PrefixedContext {
        static formKey = 'CustomerStatusDB.CustomerStatus';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CustomerStatusForm.init)  {
                CustomerStatusForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(CustomerStatusForm, [
                    'AcCustomerStatusDesc', w0,
                    'CreateBy', w0,
                    'CreateDate', w1,
                    'EditBy', w0,
                    'EditDate', w1,
                    'Stamp', w2
                ]);
            }
        }
    }
}
