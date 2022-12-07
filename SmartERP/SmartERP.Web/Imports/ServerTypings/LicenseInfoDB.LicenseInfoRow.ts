namespace SmartERP.LicenseInfoDB {
    export interface LicenseInfoRow {
        Regkey?: string;
        CompanyName?: string;
        CompanyGroupId?: string;
        CompanyRoc?: string;
        Address1?: string;
        Address2?: string;
        Address3?: string;
        Address4?: string;
        Telephone?: string;
        Fax?: string;
        Email?: string;
        Website?: string;
        ContactPerson?: string;
        Business?: string;
        SerialKey?: string;
        CardGroup?: string;
        DealerId?: string;
        DealerCompany?: string;
        DealerContact?: string;
        DealerTelephone?: string;
        DealerFax?: string;
        DealerEmail?: string;
        DealerWebsite?: string;
        CountryId?: string;
        SignatureId?: string;
        LicenseKey?: string;
        Productcode?: string;
        ProductDescription?: string;
        DatePurchase?: string;
        ActivateDate?: string;
        Remark?: string;
        SecurityCode?: string;
        SecurityCodeGenBy?: string;
        SecurityCodeGenDate?: string;
        PartnerRemark?: string;
        TransferTo?: string;
        TransferBy?: string;
        TransferDate?: string;
        TransferRemark?: string;
        CoverForSerialKey?: string;
        CoverExpiryDate?: string;
        CoverActivateBy?: string;
        CoverActivateDate?: string;
        CoverVersion?: number;
        IsBlock?: string;
        BlockBy?: string;
        BlockCreateDate?: string;
        BlockFromDate?: string;
        BlockRemark?: string;
        MsgId?: string;
        IsVoid?: string;
        VoidBy?: string;
        VoidDate?: string;
        VoidRemark?: string;
        IsActivate?: string;
        IsLicenseReady?: string;
        LicenseKeyV1?: string;
        ForceRecertifyDate?: string;
        ReserveFor?: string;
        SubDealerId?: string;
        IsCoverPlus?: string;
        TwoInOneKey?: string;
    }

    export namespace LicenseInfoRow {
        export const idProperty = 'SerialKey';
        export const nameProperty = 'Regkey';
        export const localTextPrefix = 'LicenseInfoDB.LicenseInfo';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Regkey = "Regkey",
            CompanyName = "CompanyName",
            CompanyGroupId = "CompanyGroupId",
            CompanyRoc = "CompanyRoc",
            Address1 = "Address1",
            Address2 = "Address2",
            Address3 = "Address3",
            Address4 = "Address4",
            Telephone = "Telephone",
            Fax = "Fax",
            Email = "Email",
            Website = "Website",
            ContactPerson = "ContactPerson",
            Business = "Business",
            SerialKey = "SerialKey",
            CardGroup = "CardGroup",
            DealerId = "DealerId",
            DealerCompany = "DealerCompany",
            DealerContact = "DealerContact",
            DealerTelephone = "DealerTelephone",
            DealerFax = "DealerFax",
            DealerEmail = "DealerEmail",
            DealerWebsite = "DealerWebsite",
            CountryId = "CountryId",
            SignatureId = "SignatureId",
            LicenseKey = "LicenseKey",
            Productcode = "Productcode",
            ProductDescription = "ProductDescription",
            DatePurchase = "DatePurchase",
            ActivateDate = "ActivateDate",
            Remark = "Remark",
            SecurityCode = "SecurityCode",
            SecurityCodeGenBy = "SecurityCodeGenBy",
            SecurityCodeGenDate = "SecurityCodeGenDate",
            PartnerRemark = "PartnerRemark",
            TransferTo = "TransferTo",
            TransferBy = "TransferBy",
            TransferDate = "TransferDate",
            TransferRemark = "TransferRemark",
            CoverForSerialKey = "CoverForSerialKey",
            CoverExpiryDate = "CoverExpiryDate",
            CoverActivateBy = "CoverActivateBy",
            CoverActivateDate = "CoverActivateDate",
            CoverVersion = "CoverVersion",
            IsBlock = "IsBlock",
            BlockBy = "BlockBy",
            BlockCreateDate = "BlockCreateDate",
            BlockFromDate = "BlockFromDate",
            BlockRemark = "BlockRemark",
            MsgId = "MsgId",
            IsVoid = "IsVoid",
            VoidBy = "VoidBy",
            VoidDate = "VoidDate",
            VoidRemark = "VoidRemark",
            IsActivate = "IsActivate",
            IsLicenseReady = "IsLicenseReady",
            LicenseKeyV1 = "LicenseKeyV1",
            ForceRecertifyDate = "ForceRecertifyDate",
            ReserveFor = "ReserveFor",
            SubDealerId = "SubDealerId",
            IsCoverPlus = "IsCoverPlus",
            TwoInOneKey = "TwoInOneKey"
        }
    }
}
