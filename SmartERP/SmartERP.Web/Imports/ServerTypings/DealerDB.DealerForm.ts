namespace SmartERP.DealerDB {
    export interface DealerForm {
        DealerId: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        ContactNo: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Country: Serenity.StringEditor;
        State: Serenity.StringEditor;
        City: Serenity.StringEditor;
        PostCode: Serenity.StringEditor;
        IsSubDealer: Serenity.StringEditor;
        Active: Serenity.StringEditor;
        CreateBy: Serenity.StringEditor;
        CreateDate: Serenity.DateEditor;
        EditBy: Serenity.StringEditor;
        EditDate: Serenity.DateEditor;
        Stamp: Serenity.IntegerEditor;
        CoverDocNoPreFix: Serenity.StringEditor;
        CoverLastDocNo: Serenity.IntegerEditor;
        IsTaxExclusive: Serenity.StringEditor;
    }

    export class DealerForm extends Serenity.PrefixedContext {
        static formKey = 'DealerDB.Dealer';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DealerForm.init)  {
                DealerForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(DealerForm, [
                    'DealerId', w0,
                    'Name', w0,
                    'ContactNo', w0,
                    'Email', w0,
                    'Address', w0,
                    'Country', w0,
                    'State', w0,
                    'City', w0,
                    'PostCode', w0,
                    'IsSubDealer', w0,
                    'Active', w0,
                    'CreateBy', w0,
                    'CreateDate', w1,
                    'EditBy', w0,
                    'EditDate', w1,
                    'Stamp', w2,
                    'CoverDocNoPreFix', w0,
                    'CoverLastDocNo', w2,
                    'IsTaxExclusive', w0
                ]);
            }
        }
    }
}
