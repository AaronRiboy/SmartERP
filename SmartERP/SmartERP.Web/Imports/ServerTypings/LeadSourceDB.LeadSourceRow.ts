namespace SmartERP.LeadSourceDB {
    export interface LeadSourceRow {
        AcLeadSourceId?: string;
        AcLeadSourceDesc?: string;
        CreateBy?: string;
        CreateDate?: string;
        EditBy?: string;
        EditDate?: string;
        Stamp?: number;
    }

    export namespace LeadSourceRow {
        export const idProperty = 'AcLeadSourceId';
        export const nameProperty = 'AcLeadSourceId';
        export const localTextPrefix = 'LeadSourceDB.LeadSource';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            AcLeadSourceId = "AcLeadSourceId",
            AcLeadSourceDesc = "AcLeadSourceDesc",
            CreateBy = "CreateBy",
            CreateDate = "CreateDate",
            EditBy = "EditBy",
            EditDate = "EditDate",
            Stamp = "Stamp"
        }
    }
}
