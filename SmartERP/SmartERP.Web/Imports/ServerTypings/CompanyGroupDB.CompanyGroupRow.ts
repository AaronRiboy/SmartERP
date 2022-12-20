namespace SmartERP.CompanyGroupDB {
    export interface CompanyGroupRow {
        AcCompanyGroupId?: string;
        AcCompanyGroupDesc?: string;
        DealerId?: string;
        CreateBy?: string;
        CreateDate?: string;
        EditBy?: string;
        EditDate?: string;
        Stamp?: number;
        Active?: string;
        ContactPerson?: string;
        ContactEmail?: string;
        ContactNo?: string;
        SlcRenewDate?: string;
        SlcExpiryDate?: string;
        Remark?: string;
        SlcAmount?: number;
        TotalInCardMember?: number;
        LastFollowUpDate?: string;
        TotalPos?: number;
        NumberOfOutlet?: number;
        IntegrationTo?: string;
        AcBusinessNatureId?: string;
        AcCustomerStatusId?: string;
        Masterdealer?: string;
        PropertyId?: string;
    }

    export namespace CompanyGroupRow {
        export const idProperty = 'PropertyId';
        export const nameProperty = 'AcCompanyGroupId';
        export const localTextPrefix = 'CompanyGroupDB.CompanyGroup';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            AcCompanyGroupId = "AcCompanyGroupId",
            AcCompanyGroupDesc = "AcCompanyGroupDesc",
            DealerId = "DealerId",
            CreateBy = "CreateBy",
            CreateDate = "CreateDate",
            EditBy = "EditBy",
            EditDate = "EditDate",
            Stamp = "Stamp",
            Active = "Active",
            ContactPerson = "ContactPerson",
            ContactEmail = "ContactEmail",
            ContactNo = "ContactNo",
            SlcRenewDate = "SlcRenewDate",
            SlcExpiryDate = "SlcExpiryDate",
            Remark = "Remark",
            SlcAmount = "SlcAmount",
            TotalInCardMember = "TotalInCardMember",
            LastFollowUpDate = "LastFollowUpDate",
            TotalPos = "TotalPos",
            NumberOfOutlet = "NumberOfOutlet",
            IntegrationTo = "IntegrationTo",
            AcBusinessNatureId = "AcBusinessNatureId",
            AcCustomerStatusId = "AcCustomerStatusId",
            Masterdealer = "Masterdealer",
            PropertyId = "PropertyId"
        }
    }
}
