namespace SmartERP.CountryDB {
    export interface CountryRow {
        AcCountryId?: string;
        AcCountryDesc?: string;
        CreateBy?: string;
        CreateDate?: string;
        EditBy?: string;
        EditDate?: string;
        Stamp?: number;
    }

    export namespace CountryRow {
        export const idProperty = 'AcCountryId';
        export const nameProperty = 'AcCountryId';
        export const localTextPrefix = 'CountryDB.Country';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            AcCountryId = "AcCountryId",
            AcCountryDesc = "AcCountryDesc",
            CreateBy = "CreateBy",
            CreateDate = "CreateDate",
            EditBy = "EditBy",
            EditDate = "EditDate",
            Stamp = "Stamp"
        }
    }
}
