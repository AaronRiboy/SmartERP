using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.CompanyGroupDB
{
    [ConnectionKey("SmartLicenseDB"), Module("CompanyGroupDB"), TableName("[dbo].[AcCompanyGroup]")]
    [DisplayName("Company Group"), InstanceName("Company Group")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class CompanyGroupRow : Row<CompanyGroupRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Ac Company Group Id"), Column("AcCompanyGroupID"), Size(100), PrimaryKey, IdProperty, QuickSearch, NameProperty]
        public String AcCompanyGroupId
        {
            get => fields.AcCompanyGroupId[this];
            set => fields.AcCompanyGroupId[this] = value;
        }

        [DisplayName("Ac Company Group Desc"), Size(100), NotNull]
        public String AcCompanyGroupDesc
        {
            get => fields.AcCompanyGroupDesc[this];
            set => fields.AcCompanyGroupDesc[this] = value;
        }

        [DisplayName("Dealer Id"), Column("DealerID"), Size(50), PrimaryKey]
        public String DealerId
        {
            get => fields.DealerId[this];
            set => fields.DealerId[this] = value;
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

        [DisplayName("Active"), Column("ACTIVE"), Size(1)]
        public String Active
        {
            get => fields.Active[this];
            set => fields.Active[this] = value;
        }

        [DisplayName("Contact Person"), Size(50)]
        public String ContactPerson
        {
            get => fields.ContactPerson[this];
            set => fields.ContactPerson[this] = value;
        }

        [DisplayName("Contact Email"), Size(50)]
        public String ContactEmail
        {
            get => fields.ContactEmail[this];
            set => fields.ContactEmail[this] = value;
        }

        [DisplayName("Contact No"), Size(20)]
        public String ContactNo
        {
            get => fields.ContactNo[this];
            set => fields.ContactNo[this] = value;
        }

        [DisplayName("Slc Renew Date"), Column("SLCRenewDate")]
        public DateTime? SlcRenewDate
        {
            get => fields.SlcRenewDate[this];
            set => fields.SlcRenewDate[this] = value;
        }

        [DisplayName("Slc Expiry Date"), Column("SLCExpiryDate")]
        public DateTime? SlcExpiryDate
        {
            get => fields.SlcExpiryDate[this];
            set => fields.SlcExpiryDate[this] = value;
        }

        [DisplayName("Remark")]
        public String Remark
        {
            get => fields.Remark[this];
            set => fields.Remark[this] = value;
        }

        [DisplayName("Slc Amount"), Column("SLCAmount"), Size(19), Scale(4)]
        public Decimal? SlcAmount
        {
            get => fields.SlcAmount[this];
            set => fields.SlcAmount[this] = value;
        }

        [DisplayName("Total In Card Member")]
        public Int32? TotalInCardMember
        {
            get => fields.TotalInCardMember[this];
            set => fields.TotalInCardMember[this] = value;
        }

        [DisplayName("Last Follow Up Date")]
        public DateTime? LastFollowUpDate
        {
            get => fields.LastFollowUpDate[this];
            set => fields.LastFollowUpDate[this] = value;
        }

        [DisplayName("Total Pos")]
        public Int32? TotalPos
        {
            get => fields.TotalPos[this];
            set => fields.TotalPos[this] = value;
        }

        [DisplayName("Number Of Outlet")]
        public Int32? NumberOfOutlet
        {
            get => fields.NumberOfOutlet[this];
            set => fields.NumberOfOutlet[this] = value;
        }

        [DisplayName("Integration To"), Size(100)]
        public String IntegrationTo
        {
            get => fields.IntegrationTo[this];
            set => fields.IntegrationTo[this] = value;
        }

        [DisplayName("Ac Business Nature Id"), Size(100)]
        public String AcBusinessNatureId
        {
            get => fields.AcBusinessNatureId[this];
            set => fields.AcBusinessNatureId[this] = value;
        }

        [DisplayName("Ac Customer Status Id"), Size(20)]
        public String AcCustomerStatusId
        {
            get => fields.AcCustomerStatusId[this];
            set => fields.AcCustomerStatusId[this] = value;
        }

        [DisplayName("Masterdealer"), Column("masterdealer"), Size(20), PrimaryKey]
        public String Masterdealer
        {
            get => fields.Masterdealer[this];
            set => fields.Masterdealer[this] = value;
        }

        public CompanyGroupRow()
            : base()
        {
        }

        public CompanyGroupRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField AcCompanyGroupId;
            public StringField AcCompanyGroupDesc;
            public StringField DealerId;
            public StringField CreateBy;
            public DateTimeField CreateDate;
            public StringField EditBy;
            public DateTimeField EditDate;
            public Int32Field Stamp;
            public StringField Active;
            public StringField ContactPerson;
            public StringField ContactEmail;
            public StringField ContactNo;
            public DateTimeField SlcRenewDate;
            public DateTimeField SlcExpiryDate;
            public StringField Remark;
            public DecimalField SlcAmount;
            public Int32Field TotalInCardMember;
            public DateTimeField LastFollowUpDate;
            public Int32Field TotalPos;
            public Int32Field NumberOfOutlet;
            public StringField IntegrationTo;
            public StringField AcBusinessNatureId;
            public StringField AcCustomerStatusId;
            public StringField Masterdealer;
        }
    }
}
