using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.UserDB
{
    [ConnectionKey("SmartLicenseDB"), Module("UserDB"), TableName("[dbo].[AcUser]")]
    [DisplayName("User"), InstanceName("User")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class UserRow : Row<UserRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Ac User Id"), Column("AcUserID"), Size(50), PrimaryKey, IdProperty, QuickSearch, NameProperty]
        public String AcUserId
        {
            get => fields.AcUserId[this];
            set => fields.AcUserId[this] = value;
        }

        [DisplayName("Dealer Id"), Column("DealerID"), Size(20), NotNull]
        public String DealerId
        {
            get => fields.DealerId[this];
            set => fields.DealerId[this] = value;
        }

        [DisplayName("Master Dealer"), Size(20), NotNull]
        public String MasterDealer
        {
            get => fields.MasterDealer[this];
            set => fields.MasterDealer[this] = value;
        }

        [DisplayName("Ac User Group"), Column("AcUserGroupID"), Size(20), NotNull, ForeignKey("[dbo].[AcUserGroup]", "AcUserGroupID"), LeftJoin("jAcUserGroup"), TextualField("AcUserGroupAcUserGroupDesc")]
        public String AcUserGroupId
        {
            get => fields.AcUserGroupId[this];
            set => fields.AcUserGroupId[this] = value;
        }

        [DisplayName("Password Login"), Size(100), NotNull]
        public String PwdLogin
        {
            get => fields.PwdLogin[this];
            set => fields.PwdLogin[this] = value;
        }

        [DisplayName("Active"), Size(1), NotNull]
        public String Active
        {
            get => fields.Active[this];
            set => fields.Active[this] = value;
        }

        [DisplayName("Remark"), Size(50)]
        public String Remark
        {
            get => fields.Remark[this];
            set => fields.Remark[this] = value;
        }

        [DisplayName("Create By"), Size(50)]
        public String CreateBy
        {
            get => fields.CreateBy[this];
            set => fields.CreateBy[this] = value;
        }

        [DisplayName("Create Date")]
        public DateTime? CreateDate
        {
            get => fields.CreateDate[this];
            set => fields.CreateDate[this] = value;
        }

        [DisplayName("Edit By"), Size(50)]
        public String EditBy
        {
            get => fields.EditBy[this];
            set => fields.EditBy[this] = value;
        }

        [DisplayName("Edit Date")]
        public DateTime? EditDate
        {
            get => fields.EditDate[this];
            set => fields.EditDate[this] = value;
        }

        [DisplayName("Stamp"), NotNull]
        public Int32? Stamp
        {
            get => fields.Stamp[this];
            set => fields.Stamp[this] = value;
        }

        [DisplayName("Is Exclusive"), Size(1)]
        public String IsTaxExclusive
        {
            get => fields.IsTaxExclusive[this];
            set => fields.IsTaxExclusive[this] = value;
        }

        [DisplayName("User Group / User Group Description"), Expression("jAcUserGroup.[AcUserGroupDesc]")]
        public String AcUserGroupAcUserGroupDesc
        {
            get => fields.AcUserGroupAcUserGroupDesc[this];
            set => fields.AcUserGroupAcUserGroupDesc[this] = value;
        }

        [DisplayName("User Group Is Smart Staff"), Expression("jAcUserGroup.[IsSmartStaff]")]
        public String AcUserGroupIsSmartStaff
        {
            get => fields.AcUserGroupIsSmartStaff[this];
            set => fields.AcUserGroupIsSmartStaff[this] = value;
        }

        [DisplayName("User Group Create By"), Expression("jAcUserGroup.[CreateBy]")]
        public String AcUserGroupCreateBy
        {
            get => fields.AcUserGroupCreateBy[this];
            set => fields.AcUserGroupCreateBy[this] = value;
        }

        [DisplayName("User Group Create Date"), Expression("jAcUserGroup.[CreateDate]")]
        public DateTime? AcUserGroupCreateDate
        {
            get => fields.AcUserGroupCreateDate[this];
            set => fields.AcUserGroupCreateDate[this] = value;
        }

        [DisplayName("User Group Edit By"), Expression("jAcUserGroup.[EditBy]")]
        public String AcUserGroupEditBy
        {
            get => fields.AcUserGroupEditBy[this];
            set => fields.AcUserGroupEditBy[this] = value;
        }

        [DisplayName("User Group Edit Date"), Expression("jAcUserGroup.[EditDate]")]
        public DateTime? AcUserGroupEditDate
        {
            get => fields.AcUserGroupEditDate[this];
            set => fields.AcUserGroupEditDate[this] = value;
        }

        [DisplayName("User Group Stamp"), Expression("jAcUserGroup.[Stamp]")]
        public Int32? AcUserGroupStamp
        {
            get => fields.AcUserGroupStamp[this];
            set => fields.AcUserGroupStamp[this] = value;
        }

        public UserRow()
            : base()
        {
        }

        public UserRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField AcUserId;
            public StringField DealerId;
            public StringField MasterDealer;
            public StringField AcUserGroupId;
            public StringField PwdLogin;
            public StringField Active;
            public StringField Remark;
            public StringField CreateBy;
            public DateTimeField CreateDate;
            public StringField EditBy;
            public DateTimeField EditDate;
            public Int32Field Stamp;
            public StringField IsTaxExclusive;

            public StringField AcUserGroupAcUserGroupDesc;
            public StringField AcUserGroupIsSmartStaff;
            public StringField AcUserGroupCreateBy;
            public DateTimeField AcUserGroupCreateDate;
            public StringField AcUserGroupEditBy;
            public DateTimeField AcUserGroupEditDate;
            public Int32Field AcUserGroupStamp;
        }
    }
}
