namespace SmartERP.LicenseInfoDB {
    export interface LicenseInfoForm {
        Regkey: Serenity.StringEditor;
        CompanyName: Serenity.StringEditor;
        CompanyGroupId: Serenity.StringEditor;
        CompanyRoc: Serenity.StringEditor;
        Address1: Serenity.StringEditor;
        Address2: Serenity.StringEditor;
        Address3: Serenity.StringEditor;
        Address4: Serenity.StringEditor;
        Telephone: Serenity.StringEditor;
        Fax: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        Website: Serenity.StringEditor;
        ContactPerson: Serenity.StringEditor;
        Business: Serenity.StringEditor;
        CardGroup: Serenity.StringEditor;
        DealerId: Serenity.StringEditor;
        DealerCompany: Serenity.StringEditor;
        DealerContact: Serenity.StringEditor;
        DealerTelephone: Serenity.StringEditor;
        DealerFax: Serenity.StringEditor;
        DealerEmail: Serenity.StringEditor;
        DealerWebsite: Serenity.StringEditor;
        CountryId: Serenity.StringEditor;
        SignatureId: Serenity.StringEditor;
        LicenseKey: Serenity.StringEditor;
        Productcode: Serenity.StringEditor;
        ProductDescription: Serenity.StringEditor;
        DatePurchase: Serenity.DateEditor;
        ActivateDate: Serenity.DateEditor;
        Remark: Serenity.StringEditor;
        SecurityCode: Serenity.StringEditor;
        SecurityCodeGenBy: Serenity.StringEditor;
        SecurityCodeGenDate: Serenity.DateEditor;
        PartnerRemark: Serenity.StringEditor;
        TransferTo: Serenity.StringEditor;
        TransferBy: Serenity.StringEditor;
        TransferDate: Serenity.DateEditor;
        TransferRemark: Serenity.StringEditor;
        CoverForSerialKey: Serenity.StringEditor;
        CoverExpiryDate: Serenity.DateEditor;
        CoverActivateBy: Serenity.StringEditor;
        CoverActivateDate: Serenity.DateEditor;
        CoverVersion: Serenity.IntegerEditor;
        IsBlock: Serenity.StringEditor;
        BlockBy: Serenity.StringEditor;
        BlockCreateDate: Serenity.DateEditor;
        BlockFromDate: Serenity.DateEditor;
        BlockRemark: Serenity.StringEditor;
        MsgId: Serenity.StringEditor;
        IsVoid: Serenity.StringEditor;
        VoidBy: Serenity.StringEditor;
        VoidDate: Serenity.DateEditor;
        VoidRemark: Serenity.StringEditor;
        IsActivate: Serenity.StringEditor;
        IsLicenseReady: Serenity.StringEditor;
        LicenseKeyV1: Serenity.StringEditor;
        ForceRecertifyDate: Serenity.DateEditor;
        ReserveFor: Serenity.StringEditor;
        SubDealerId: Serenity.StringEditor;
        IsCoverPlus: Serenity.StringEditor;
        TwoInOneKey: Serenity.StringEditor;
    }

    export class LicenseInfoForm extends Serenity.PrefixedContext {
        static formKey = 'LicenseInfoDB.LicenseInfo';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!LicenseInfoForm.init)  {
                LicenseInfoForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(LicenseInfoForm, [
                    'Regkey', w0,
                    'CompanyName', w0,
                    'CompanyGroupId', w0,
                    'CompanyRoc', w0,
                    'Address1', w0,
                    'Address2', w0,
                    'Address3', w0,
                    'Address4', w0,
                    'Telephone', w0,
                    'Fax', w0,
                    'Email', w0,
                    'Website', w0,
                    'ContactPerson', w0,
                    'Business', w0,
                    'CardGroup', w0,
                    'DealerId', w0,
                    'DealerCompany', w0,
                    'DealerContact', w0,
                    'DealerTelephone', w0,
                    'DealerFax', w0,
                    'DealerEmail', w0,
                    'DealerWebsite', w0,
                    'CountryId', w0,
                    'SignatureId', w0,
                    'LicenseKey', w0,
                    'Productcode', w0,
                    'ProductDescription', w0,
                    'DatePurchase', w1,
                    'ActivateDate', w1,
                    'Remark', w0,
                    'SecurityCode', w0,
                    'SecurityCodeGenBy', w0,
                    'SecurityCodeGenDate', w1,
                    'PartnerRemark', w0,
                    'TransferTo', w0,
                    'TransferBy', w0,
                    'TransferDate', w1,
                    'TransferRemark', w0,
                    'CoverForSerialKey', w0,
                    'CoverExpiryDate', w1,
                    'CoverActivateBy', w0,
                    'CoverActivateDate', w1,
                    'CoverVersion', w2,
                    'IsBlock', w0,
                    'BlockBy', w0,
                    'BlockCreateDate', w1,
                    'BlockFromDate', w1,
                    'BlockRemark', w0,
                    'MsgId', w0,
                    'IsVoid', w0,
                    'VoidBy', w0,
                    'VoidDate', w1,
                    'VoidRemark', w0,
                    'IsActivate', w0,
                    'IsLicenseReady', w0,
                    'LicenseKeyV1', w0,
                    'ForceRecertifyDate', w1,
                    'ReserveFor', w0,
                    'SubDealerId', w0,
                    'IsCoverPlus', w0,
                    'TwoInOneKey', w0
                ]);
            }
        }
    }
}
