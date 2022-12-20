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
        export const deletePermission = 'Masters:Bank:Delete';
        export const insertPermission = 'Masters:Bank:Create';
        export const readPermission = 'Masters:Bank:View';
        export const updatePermission = 'Masters:Bank:Update';

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
