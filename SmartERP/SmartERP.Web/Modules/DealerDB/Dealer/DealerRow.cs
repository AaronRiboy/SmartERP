using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.DealerDB
{
    [ConnectionKey("SmartLicenseDB"), Module("DealerDB"), TableName("[dbo].[AcDealer]")]
    [DisplayName("Dealer"), InstanceName("Dealer")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class DealerRow : Row<DealerRow.RowFields>, IIdRow, INameRow
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

        [DisplayName("Name"), Size(100), NotNull]
        public String Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Contact No"), Size(20)]
        public String ContactNo
        {
            get => fields.ContactNo[this];
            set => fields.ContactNo[this] = value;
        }

        [DisplayName("Email"), Size(50)]
        public String Email
        {
            get => fields.Email[this];
            set => fields.Email[this] = value;
        }

        [DisplayName("Address"), Size(100), NotNull]
        public String Address
        {
            get => fields.Address[this];
            set => fields.Address[this] = value;
        }

        [DisplayName("Country"), Size(100), NotNull]
        public String Country
        {
            get => fields.Country[this];
            set => fields.Country[this] = value;
        }

        [DisplayName("State"), Size(100), NotNull]
        public String State
        {
            get => fields.State[this];
            set => fields.State[this] = value;
        }

        [DisplayName("City"), Size(100), NotNull]
        public String City
        {
            get => fields.City[this];
            set => fields.City[this] = value;
        }

        [DisplayName("Post Code"), Size(10), NotNull]
        public String PostCode
        {
            get => fields.PostCode[this];
            set => fields.PostCode[this] = value;
        }

        [DisplayName("Is Sub Dealer"), Size(1), NotNull]
        public String IsSubDealer
        {
            get => fields.IsSubDealer[this];
            set => fields.IsSubDealer[this] = value;
        }

        [DisplayName("Active"), Size(1), NotNull]
        public String Active
        {
            get => fields.Active[this];
            set => fields.Active[this] = value;
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

        [DisplayName("Cover Doc No Pre Fix"), Size(50)]
        public String CoverDocNoPreFix
        {
            get => fields.CoverDocNoPreFix[this];
            set => fields.CoverDocNoPreFix[this] = value;
        }

        [DisplayName("Cover Last Doc No")]
        public Int32? CoverLastDocNo
        {
            get => fields.CoverLastDocNo[this];
            set => fields.CoverLastDocNo[this] = value;
        }

        [DisplayName("Is Tax Exclusive"), Size(1)]
        public String IsTaxExclusive
        {
            get => fields.IsTaxExclusive[this];
            set => fields.IsTaxExclusive[this] = value;
        }

        public DealerRow()
            : base()
        {
        }

        public DealerRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField MasterDealer;
            public StringField DealerId;
            public StringField Name;
            public StringField ContactNo;
            public StringField Email;
            public StringField Address;
            public StringField Country;
            public StringField State;
            public StringField City;
            public StringField PostCode;
            public StringField IsSubDealer;
            public StringField Active;
            public StringField CreateBy;
            public DateTimeField CreateDate;
            public StringField EditBy;
            public DateTimeField EditDate;
            public Int32Field Stamp;
            public StringField CoverDocNoPreFix;
            public Int32Field CoverLastDocNo;
            public StringField IsTaxExclusive;
        }
    }
}
