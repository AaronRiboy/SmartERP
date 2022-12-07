namespace SmartERP.DealerDB {
    export interface DealerRow {
        MasterDealer?: string;
        DealerId?: string;
        Name?: string;
        ContactNo?: string;
        Email?: string;
        Address?: string;
        Country?: string;
        State?: string;
        City?: string;
        PostCode?: string;
        IsSubDealer?: string;
        Active?: string;
        CreateBy?: string;
        CreateDate?: string;
        EditBy?: string;
        EditDate?: string;
        Stamp?: number;
        CoverDocNoPreFix?: string;
        CoverLastDocNo?: number;
        IsTaxExclusive?: string;
    }

    export namespace DealerRow {
        export const idProperty = 'MasterDealer';
        export const nameProperty = 'MasterDealer';
        export const localTextPrefix = 'DealerDB.Dealer';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            MasterDealer = "MasterDealer",
            DealerId = "DealerId",
            Name = "Name",
            ContactNo = "ContactNo",
            Email = "Email",
            Address = "Address",
            Country = "Country",
            State = "State",
            City = "City",
            PostCode = "PostCode",
            IsSubDealer = "IsSubDealer",
            Active = "Active",
            CreateBy = "CreateBy",
            CreateDate = "CreateDate",
            EditBy = "EditBy",
            EditDate = "EditDate",
            Stamp = "Stamp",
            CoverDocNoPreFix = "CoverDocNoPreFix",
            CoverLastDocNo = "CoverLastDocNo",
            IsTaxExclusive = "IsTaxExclusive"
        }
    }
}
