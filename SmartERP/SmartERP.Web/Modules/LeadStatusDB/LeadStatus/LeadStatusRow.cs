using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.LeadStatusDB
{
    [ConnectionKey("SmartLicenseDB"), Module("LeadStatusDB"), TableName("[dbo].[AcLeadStatus]")]
    [DisplayName("Lead Status"), InstanceName("Lead Status")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class LeadStatusRow : Row<LeadStatusRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Ac Lead Status Id"), Column("AcLeadStatusID"), Size(20), PrimaryKey, IdProperty, QuickSearch, NameProperty]
        public String AcLeadStatusId
        {
            get => fields.AcLeadStatusId[this];
            set => fields.AcLeadStatusId[this] = value;
        }

        [DisplayName("Lead Status Description"), Size(100), NotNull]
        public String AcLeadStatusDesc
        {
            get => fields.AcLeadStatusDesc[this];
            set => fields.AcLeadStatusDesc[this] = value;
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

        public LeadStatusRow()
            : base()
        {
        }

        public LeadStatusRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField AcLeadStatusId;
            public StringField AcLeadStatusDesc;
            public StringField CreateBy;
            public DateTimeField CreateDate;
            public StringField EditBy;
            public DateTimeField EditDate;
            public Int32Field Stamp;
        }
    }
}
