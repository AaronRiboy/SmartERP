namespace SmartERP.CompanyGroupDB {
    export interface CompanyGroupForm {
        AcCompanyGroupDesc: Serenity.StringEditor;
        DealerId: Serenity.StringEditor;
        CreateBy: Serenity.StringEditor;
        CreateDate: Serenity.DateEditor;
        EditBy: Serenity.StringEditor;
        EditDate: Serenity.DateEditor;
        Stamp: Serenity.IntegerEditor;
        Active: Serenity.StringEditor;
        ContactPerson: Serenity.StringEditor;
        ContactEmail: Serenity.StringEditor;
        ContactNo: Serenity.StringEditor;
        SlcRenewDate: Serenity.DateEditor;
        SlcExpiryDate: Serenity.DateEditor;
        Remark: Serenity.StringEditor;
        SlcAmount: Serenity.DecimalEditor;
        TotalInCardMember: Serenity.IntegerEditor;
        LastFollowUpDate: Serenity.DateEditor;
        TotalPos: Serenity.IntegerEditor;
        NumberOfOutlet: Serenity.IntegerEditor;
        IntegrationTo: Serenity.StringEditor;
        AcBusinessNatureId: Serenity.StringEditor;
        AcCustomerStatusId: Serenity.StringEditor;
        Masterdealer: Serenity.StringEditor;
    }

    export class CompanyGroupForm extends Serenity.PrefixedContext {
        static formKey = 'CompanyGroupDB.CompanyGroup';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CompanyGroupForm.init)  {
                CompanyGroupForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DecimalEditor;

                Q.initFormType(CompanyGroupForm, [
                    'AcCompanyGroupDesc', w0,
                    'DealerId', w0,
                    'CreateBy', w0,
                    'CreateDate', w1,
                    'EditBy', w0,
                    'EditDate', w1,
                    'Stamp', w2,
                    'Active', w0,
                    'ContactPerson', w0,
                    'ContactEmail', w0,
                    'ContactNo', w0,
                    'SlcRenewDate', w1,
                    'SlcExpiryDate', w1,
                    'Remark', w0,
                    'SlcAmount', w3,
                    'TotalInCardMember', w2,
                    'LastFollowUpDate', w1,
                    'TotalPos', w2,
                    'NumberOfOutlet', w2,
                    'IntegrationTo', w0,
                    'AcBusinessNatureId', w0,
                    'AcCustomerStatusId', w0,
                    'Masterdealer', w0
                ]);
            }
        }
    }
}
