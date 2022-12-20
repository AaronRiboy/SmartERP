using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.BusinessNatureDB
{
    [ConnectionKey("SmartLicenseDB"), Module("BusinessNatureDB"), TableName("[dbo].[AcBusinessNature]")]
    [DisplayName("Business Nature"), InstanceName("Business Nature")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("BusinessNatureDB.BusinessNature")]
    public sealed class BusinessNatureRow : Row<BusinessNatureRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Ac Business Nature Id"), Column("AcBusinessNatureID"), Size(100), PrimaryKey, IdProperty, QuickSearch, NameProperty]
        public String AcBusinessNatureId
        {
            get => fields.AcBusinessNatureId[this];
            set => fields.AcBusinessNatureId[this] = value;
        }

        [DisplayName("Business Nature Description"), Size(100), NotNull]
        public String AcBusinessNatureDesc
        {
            get => fields.AcBusinessNatureDesc[this];
            set => fields.AcBusinessNatureDesc[this] = value;
        }

        [DisplayName("Order No"), NotNull]
        public Int32? OrderNo
        {
            get => fields.OrderNo[this];
            set => fields.OrderNo[this] = value;
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

        [DisplayName("Business Nature Grp Id"), Size(20)]
        public String AcBusinessNatureGrpId
        {
            get => fields.AcBusinessNatureGrpId[this];
            set => fields.AcBusinessNatureGrpId[this] = value;
        }

        public BusinessNatureRow()
            : base()
        {
        }

        public BusinessNatureRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField AcBusinessNatureId;
            public StringField AcBusinessNatureDesc;
            public Int32Field OrderNo;
            public StringField CreateBy;
            public DateTimeField CreateDate;
            public StringField EditBy;
            public DateTimeField EditDate;
            public Int32Field Stamp;
            public StringField AcBusinessNatureGrpId;
        }
    }
}
