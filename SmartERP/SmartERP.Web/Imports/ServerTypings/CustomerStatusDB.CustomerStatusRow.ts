namespace SmartERP.CustomerStatusDB {
    export interface CustomerStatusRow {
        AcCustomerStatusId?: string;
        AcCustomerStatusDesc?: string;
        CreateBy?: string;
        CreateDate?: string;
        EditBy?: string;
        EditDate?: string;
        Stamp?: number;
    }

    export namespace CustomerStatusRow {
        export const idProperty = 'AcCustomerStatusId';
        export const nameProperty = 'AcCustomerStatusId';
        export const localTextPrefix = 'CustomerStatusDB.CustomerStatus';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            AcCustomerStatusId = "AcCustomerStatusId",
            AcCustomerStatusDesc = "AcCustomerStatusDesc",
            CreateBy = "CreateBy",
            CreateDate = "CreateDate",
            EditBy = "EditBy",
            EditDate = "EditDate",
            Stamp = "Stamp"
        }
    }
}
