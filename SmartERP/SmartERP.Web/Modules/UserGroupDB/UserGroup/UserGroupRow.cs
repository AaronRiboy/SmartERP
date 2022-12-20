using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.UserGroupDB
{
    [ConnectionKey("SmartLicenseDB"), Module("UserGroupDB"), TableName("[dbo].[AcUserGroup]")]
    [DisplayName("User Group"), InstanceName("User Group")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class UserGroupRow : Row<UserGroupRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Ac User Group Id"), Column("AcUserGroupID"), Size(20), PrimaryKey, IdProperty, QuickSearch, NameProperty]
        public String AcUserGroupId
        {
            get => fields.AcUserGroupId[this];
            set => fields.AcUserGroupId[this] = value;
        }

        [DisplayName("User Group Description"), Size(100), NotNull]
        public String AcUserGroupDesc
        {
            get => fields.AcUserGroupDesc[this];
            set => fields.AcUserGroupDesc[this] = value;
        }

        [DisplayName("Is Smart Staff"), Size(1), NotNull]
        public String IsSmartStaff
        {
            get => fields.IsSmartStaff[this];
            set => fields.IsSmartStaff[this] = value;
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

        public UserGroupRow()
            : base()
        {
        }

        public UserGroupRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField AcUserGroupId;
            public StringField AcUserGroupDesc;
            public StringField IsSmartStaff;
            public StringField CreateBy;
            public DateTimeField CreateDate;
            public StringField EditBy;
            public DateTimeField EditDate;
            public Int32Field Stamp;
        }
    }
}
