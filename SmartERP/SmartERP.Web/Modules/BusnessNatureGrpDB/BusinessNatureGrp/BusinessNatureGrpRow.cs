using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.BusnessNatureGrpDB
{
    [ConnectionKey("SmartLicenseDB"), Module("BusnessNatureGrpDB"), TableName("[dbo].[AcBusinessNatureGrp]")]
    [DisplayName("Business Nature Group"), InstanceName("Business Nature Grp")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class BusinessNatureGrpRow : Row<BusinessNatureGrpRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Ac Business Nature Grp Id"), Column("AcBusinessNatureGrpID"), Size(100), PrimaryKey, IdProperty, QuickSearch, NameProperty]
        public String AcBusinessNatureGrpId
        {
            get => fields.AcBusinessNatureGrpId[this];
            set => fields.AcBusinessNatureGrpId[this] = value;
        }

        [DisplayName("Business Nature Group Description"), Size(100), NotNull]
        public String AcBusinessNatureGrpDesc
        {
            get => fields.AcBusinessNatureGrpDesc[this];
            set => fields.AcBusinessNatureGrpDesc[this] = value;
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

        public BusinessNatureGrpRow()
            : base()
        {
        }

        public BusinessNatureGrpRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField AcBusinessNatureGrpId;
            public StringField AcBusinessNatureGrpDesc;
            public StringField CreateBy;
            public DateTimeField CreateDate;
            public StringField EditBy;
            public DateTimeField EditDate;
            public Int32Field Stamp;
        }
    }
}
