namespace SmartERP.SalesPersonDB {
    export interface SalesPersonRow {
        MasterDealer?: string;
        DealerId?: string;
        AcSalesPersonId?: string;
        AcSalesPersonDesc?: string;
        CreateBy?: string;
        CreateDate?: string;
        EditBy?: string;
        EditDate?: string;
        Stamp?: number;
    }

    export namespace SalesPersonRow {
        export const idProperty = 'MasterDealer';
        export const nameProperty = 'MasterDealer';
        export const localTextPrefix = 'SalesPersonDB.SalesPerson';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            MasterDealer = "MasterDealer",
            DealerId = "DealerId",
            AcSalesPersonId = "AcSalesPersonId",
            AcSalesPersonDesc = "AcSalesPersonDesc",
            CreateBy = "CreateBy",
            CreateDate = "CreateDate",
            EditBy = "EditBy",
            EditDate = "EditDate",
            Stamp = "Stamp"
        }
    }
}
