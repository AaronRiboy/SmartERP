using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.SalesPersonDB
{
    [ConnectionKey("SmartLicenseDB"), Module("SalesPersonDB"), TableName("[dbo].[AcSalesPerson]")]
    [DisplayName("Sales Person"), InstanceName("Sales Person")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class SalesPersonRow : Row<SalesPersonRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Master Dealer"), Size(20), PrimaryKey, IdProperty, QuickSearch, NameProperty]
        public String MasterDealer
        {
            get => fields.MasterDealer[this];
            set => fields.MasterDealer[this] = value;
        }

        [DisplayName("Dealer Id"), Column("DealerID"), Size(20), PrimaryKey]
        public String DealerId
        {
            get => fields.DealerId[this];
            set => fields.DealerId[this] = value;
        }

        [DisplayName("Ac Sales Person Id"), Column("AcSalesPersonID"), Size(100), PrimaryKey]
        public String AcSalesPersonId
        {
            get => fields.AcSalesPersonId[this];
            set => fields.AcSalesPersonId[this] = value;
        }

        [DisplayName("Ac Sales Person Desc"), Size(100), NotNull]
        public String AcSalesPersonDesc
        {
            get => fields.AcSalesPersonDesc[this];
            set => fields.AcSalesPersonDesc[this] = value;
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

        public SalesPersonRow()
            : base()
        {
        }

        public SalesPersonRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField MasterDealer;
            public StringField DealerId;
            public StringField AcSalesPersonId;
            public StringField AcSalesPersonDesc;
            public StringField CreateBy;
            public DateTimeField CreateDate;
            public StringField EditBy;
            public DateTimeField EditDate;
            public Int32Field Stamp;
        }
    }
}
