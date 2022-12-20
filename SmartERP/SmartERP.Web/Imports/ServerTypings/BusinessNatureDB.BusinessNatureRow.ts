namespace SmartERP.BusinessNatureDB {
    export interface BusinessNatureRow {
        AcBusinessNatureId?: string;
        AcBusinessNatureDesc?: string;
        OrderNo?: number;
        CreateBy?: string;
        CreateDate?: string;
        EditBy?: string;
        EditDate?: string;
        Stamp?: number;
        AcBusinessNatureGrpId?: string;
    }

    export namespace BusinessNatureRow {
        export const idProperty = 'AcBusinessNatureId';
        export const nameProperty = 'AcBusinessNatureId';
        export const localTextPrefix = 'BusinessNatureDB.BusinessNature';
        export const lookupKey = 'BusinessNatureDB.BusinessNature';

        export function getLookup(): Q.Lookup<BusinessNatureRow> {
            return Q.getLookup<BusinessNatureRow>('BusinessNatureDB.BusinessNature');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            AcBusinessNatureId = "AcBusinessNatureId",
            AcBusinessNatureDesc = "AcBusinessNatureDesc",
            OrderNo = "OrderNo",
            CreateBy = "CreateBy",
            CreateDate = "CreateDate",
            EditBy = "EditBy",
            EditDate = "EditDate",
            Stamp = "Stamp",
            AcBusinessNatureGrpId = "AcBusinessNatureGrpId"
        }
    }
}
