namespace SmartERP.SalesPersonDB {
    export interface SalesPersonForm {
        DealerId: Serenity.StringEditor;
        AcSalesPersonId: Serenity.StringEditor;
        AcSalesPersonDesc: Serenity.StringEditor;
        CreateBy: Serenity.StringEditor;
        CreateDate: Serenity.DateEditor;
        EditBy: Serenity.StringEditor;
        EditDate: Serenity.DateEditor;
        Stamp: Serenity.IntegerEditor;
    }

    export class SalesPersonForm extends Serenity.PrefixedContext {
        static formKey = 'SalesPersonDB.SalesPerson';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SalesPersonForm.init)  {
                SalesPersonForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(SalesPersonForm, [
                    'DealerId', w0,
                    'AcSalesPersonId', w0,
                    'AcSalesPersonDesc', w0,
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
