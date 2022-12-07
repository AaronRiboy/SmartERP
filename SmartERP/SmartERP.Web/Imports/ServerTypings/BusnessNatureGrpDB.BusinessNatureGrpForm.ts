namespace SmartERP.BusnessNatureGrpDB {
    export interface BusinessNatureGrpForm {
        AcBusinessNatureGrpDesc: Serenity.StringEditor;
        CreateBy: Serenity.StringEditor;
        CreateDate: Serenity.DateEditor;
        EditBy: Serenity.StringEditor;
        EditDate: Serenity.DateEditor;
        Stamp: Serenity.IntegerEditor;
    }

    export class BusinessNatureGrpForm extends Serenity.PrefixedContext {
        static formKey = 'BusnessNatureGrpDB.BusinessNatureGrp';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BusinessNatureGrpForm.init)  {
                BusinessNatureGrpForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(BusinessNatureGrpForm, [
                    'AcBusinessNatureGrpDesc', w0,
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
