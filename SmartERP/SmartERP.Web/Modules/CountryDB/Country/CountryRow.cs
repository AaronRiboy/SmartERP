using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.CountryDB
{
    [ConnectionKey("SmartLicenseDB"), Module("CountryDB"), TableName("[dbo].[AcCountry]")]
    [DisplayName("Country"), InstanceName("Country")]
    [ReadPermission(Masters.PermissionKeys.Banks.View)]
    [InsertPermission(Masters.PermissionKeys.Banks.Create)]
    [UpdatePermission(Masters.PermissionKeys.Banks.Update)]
    [DeletePermission(Masters.PermissionKeys.Banks.Delete)]
    public sealed class CountryRow : Row<CountryRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Ac Country Id"), Column("AcCountryID"), Size(20), PrimaryKey, IdProperty, QuickSearch, NameProperty]
        public String AcCountryId
        {
            get => fields.AcCountryId[this];
            set => fields.AcCountryId[this] = value;
        }

        [DisplayName("Country Description"), Size(100), NotNull, QuickSearch(SearchType.StartsWith)]

        public String AcCountryDesc
        {
            get => fields.AcCountryDesc[this];
            set => fields.AcCountryDesc[this] = value;
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

        public CountryRow()
            : base()
        {
        }

        public CountryRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField AcCountryId;
            public StringField AcCountryDesc;
            public StringField CreateBy;
            public DateTimeField CreateDate;
            public StringField EditBy;
            public DateTimeField EditDate;
            public Int32Field Stamp;
        }
    }
}
