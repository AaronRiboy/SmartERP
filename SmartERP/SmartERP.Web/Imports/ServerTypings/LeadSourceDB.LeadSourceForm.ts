namespace SmartERP.LeadSourceDB {
    export interface LeadSourceForm {
        AcLeadSourceDesc: Serenity.StringEditor;
        CreateBy: Serenity.StringEditor;
        CreateDate: Serenity.DateEditor;
        EditBy: Serenity.StringEditor;
        EditDate: Serenity.DateEditor;
        Stamp: Serenity.IntegerEditor;
    }

    export class LeadSourceForm extends Serenity.PrefixedContext {
        static formKey = 'LeadSourceDB.LeadSource';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!LeadSourceForm.init)  {
                LeadSourceForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(LeadSourceForm, [
                    'AcLeadSourceDesc', w0,
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
