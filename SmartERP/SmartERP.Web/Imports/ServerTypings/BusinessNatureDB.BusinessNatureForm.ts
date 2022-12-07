namespace SmartERP.BusinessNatureDB {
    export interface BusinessNatureForm {
        AcBusinessNatureDesc: Serenity.StringEditor;
        OrderNo: Serenity.IntegerEditor;
        CreateBy: Serenity.StringEditor;
        CreateDate: Serenity.DateEditor;
        EditBy: Serenity.StringEditor;
        EditDate: Serenity.DateEditor;
        Stamp: Serenity.IntegerEditor;
        AcBusinessNatureGrpId: Serenity.StringEditor;
    }

    export class BusinessNatureForm extends Serenity.PrefixedContext {
        static formKey = 'BusinessNatureDB.BusinessNature';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BusinessNatureForm.init)  {
                BusinessNatureForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(BusinessNatureForm, [
                    'AcBusinessNatureDesc', w0,
                    'OrderNo', w1,
                    'CreateBy', w0,
                    'CreateDate', w2,
                    'EditBy', w0,
                    'EditDate', w2,
                    'Stamp', w1,
                    'AcBusinessNatureGrpId', w0
                ]);
            }
        }
    }
}
