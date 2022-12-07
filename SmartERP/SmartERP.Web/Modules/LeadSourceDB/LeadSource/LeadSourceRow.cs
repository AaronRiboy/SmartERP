using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.LeadSourceDB
{
    [ConnectionKey("SmartLicenseDB"), Module("LeadSourceDB"), TableName("[dbo].[AcLeadSource]")]
    [DisplayName("Lead Source"), InstanceName("Lead Source")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class LeadSourceRow : Row<LeadSourceRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Ac Lead Source Id"), Column("AcLeadSourceID"), Size(20), PrimaryKey, IdProperty, QuickSearch, NameProperty]
        public String AcLeadSourceId
        {
            get => fields.AcLeadSourceId[this];
            set => fields.AcLeadSourceId[this] = value;
        }

        [DisplayName("Ac Lead Source Desc"), Size(100), NotNull]
        public String AcLeadSourceDesc
        {
            get => fields.AcLeadSourceDesc[this];
            set => fields.AcLeadSourceDesc[this] = value;
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

        public LeadSourceRow()
            : base()
        {
        }

        public LeadSourceRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField AcLeadSourceId;
            public StringField AcLeadSourceDesc;
            public StringField CreateBy;
            public DateTimeField CreateDate;
            public StringField EditBy;
            public DateTimeField EditDate;
            public Int32Field Stamp;
        }
    }
}
