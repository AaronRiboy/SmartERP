namespace SmartERP.LeadStatusDB {
    export interface LeadStatusForm {
        AcLeadStatusDesc: Serenity.StringEditor;
        CreateBy: Serenity.StringEditor;
        CreateDate: Serenity.DateEditor;
        EditBy: Serenity.StringEditor;
        EditDate: Serenity.DateEditor;
        Stamp: Serenity.IntegerEditor;
    }

    export class LeadStatusForm extends Serenity.PrefixedContext {
        static formKey = 'LeadStatusDB.LeadStatus';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!LeadStatusForm.init)  {
                LeadStatusForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(LeadStatusForm, [
                    'AcLeadStatusDesc', w0,
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
