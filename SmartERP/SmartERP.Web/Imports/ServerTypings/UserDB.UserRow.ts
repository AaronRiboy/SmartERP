namespace SmartERP.UserDB {
    export interface UserRow {
        AcUserId?: string;
        DealerId?: string;
        MasterDealer?: string;
        AcUserGroupId?: string;
        PwdLogin?: string;
        Active?: string;
        Remark?: string;
        CreateBy?: string;
        CreateDate?: string;
        EditBy?: string;
        EditDate?: string;
        Stamp?: number;
        IsTaxExclusive?: string;
        AcUserGroupAcUserGroupDesc?: string;
        AcUserGroupIsSmartStaff?: string;
        AcUserGroupCreateBy?: string;
        AcUserGroupCreateDate?: string;
        AcUserGroupEditBy?: string;
        AcUserGroupEditDate?: string;
        AcUserGroupStamp?: number;
    }

    export namespace UserRow {
        export const idProperty = 'AcUserId';
        export const nameProperty = 'AcUserId';
        export const localTextPrefix = 'UserDB.User';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            AcUserId = "AcUserId",
            DealerId = "DealerId",
            MasterDealer = "MasterDealer",
            AcUserGroupId = "AcUserGroupId",
            PwdLogin = "PwdLogin",
            Active = "Active",
            Remark = "Remark",
            CreateBy = "CreateBy",
            CreateDate = "CreateDate",
            EditBy = "EditBy",
            EditDate = "EditDate",
            Stamp = "Stamp",
            IsTaxExclusive = "IsTaxExclusive",
            AcUserGroupAcUserGroupDesc = "AcUserGroupAcUserGroupDesc",
            AcUserGroupIsSmartStaff = "AcUserGroupIsSmartStaff",
            AcUserGroupCreateBy = "AcUserGroupCreateBy",
            AcUserGroupCreateDate = "AcUserGroupCreateDate",
            AcUserGroupEditBy = "AcUserGroupEditBy",
            AcUserGroupEditDate = "AcUserGroupEditDate",
            AcUserGroupStamp = "AcUserGroupStamp"
        }
    }
}
