using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.CustomerStatusDB
{
    [ConnectionKey("SmartLicenseDB"), Module("CustomerStatusDB"), TableName("[dbo].[AcCustomerStatus]")]
    [DisplayName("Customer Status"), InstanceName("Customer Status")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class CustomerStatusRow : Row<CustomerStatusRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Ac Customer Status Id"), Column("AcCustomerStatusID"), Size(20), PrimaryKey, IdProperty, QuickSearch, NameProperty]
        public String AcCustomerStatusId
        {
            get => fields.AcCustomerStatusId[this];
            set => fields.AcCustomerStatusId[this] = value;
        }

        [DisplayName("Customer Status Description"), Size(100), NotNull]
        public String AcCustomerStatusDesc
        {
            get => fields.AcCustomerStatusDesc[this];
            set => fields.AcCustomerStatusDesc[this] = value;
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

        public CustomerStatusRow()
            : base()
        {
        }

        public CustomerStatusRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField AcCustomerStatusId;
            public StringField AcCustomerStatusDesc;
            public StringField CreateBy;
            public DateTimeField CreateDate;
            public StringField EditBy;
            public DateTimeField EditDate;
            public Int32Field Stamp;
        }
    }
}
