namespace SmartERP.LeadStatusDB {
    export interface LeadStatusRow {
        AcLeadStatusId?: string;
        AcLeadStatusDesc?: string;
        CreateBy?: string;
        CreateDate?: string;
        EditBy?: string;
        EditDate?: string;
        Stamp?: number;
    }

    export namespace LeadStatusRow {
        export const idProperty = 'AcLeadStatusId';
        export const nameProperty = 'AcLeadStatusId';
        export const localTextPrefix = 'LeadStatusDB.LeadStatus';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            AcLeadStatusId = "AcLeadStatusId",
            AcLeadStatusDesc = "AcLeadStatusDesc",
            CreateBy = "CreateBy",
            CreateDate = "CreateDate",
            EditBy = "EditBy",
            EditDate = "EditDate",
            Stamp = "Stamp"
        }
    }
}
