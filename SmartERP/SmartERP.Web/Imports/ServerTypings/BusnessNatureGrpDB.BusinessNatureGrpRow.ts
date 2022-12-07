namespace SmartERP.BusnessNatureGrpDB {
    export interface BusinessNatureGrpRow {
        AcBusinessNatureGrpId?: string;
        AcBusinessNatureGrpDesc?: string;
        CreateBy?: string;
        CreateDate?: string;
        EditBy?: string;
        EditDate?: string;
        Stamp?: number;
    }

    export namespace BusinessNatureGrpRow {
        export const idProperty = 'AcBusinessNatureGrpId';
        export const nameProperty = 'AcBusinessNatureGrpId';
        export const localTextPrefix = 'BusnessNatureGrpDB.BusinessNatureGrp';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            AcBusinessNatureGrpId = "AcBusinessNatureGrpId",
            AcBusinessNatureGrpDesc = "AcBusinessNatureGrpDesc",
            CreateBy = "CreateBy",
            CreateDate = "CreateDate",
            EditBy = "EditBy",
            EditDate = "EditDate",
            Stamp = "Stamp"
        }
    }
}
