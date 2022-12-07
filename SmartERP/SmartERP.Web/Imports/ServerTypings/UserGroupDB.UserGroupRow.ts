namespace SmartERP.UserGroupDB {
    export interface UserGroupRow {
        AcUserGroupId?: string;
        AcUserGroupDesc?: string;
        IsSmartStaff?: string;
        CreateBy?: string;
        CreateDate?: string;
        EditBy?: string;
        EditDate?: string;
        Stamp?: number;
    }

    export namespace UserGroupRow {
        export const idProperty = 'AcUserGroupId';
        export const nameProperty = 'AcUserGroupId';
        export const localTextPrefix = 'UserGroupDB.UserGroup';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            AcUserGroupId = "AcUserGroupId",
            AcUserGroupDesc = "AcUserGroupDesc",
            IsSmartStaff = "IsSmartStaff",
            CreateBy = "CreateBy",
            CreateDate = "CreateDate",
            EditBy = "EditBy",
            EditDate = "EditDate",
            Stamp = "Stamp"
        }
    }
}
