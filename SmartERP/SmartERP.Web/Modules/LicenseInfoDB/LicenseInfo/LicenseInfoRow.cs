using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.LicenseInfoDB
{
    [ConnectionKey("SmartLicenseDB"), Module("LicenseInfoDB"), TableName("[dbo].[AcLicenseInfo]")]
    [DisplayName("License Info"), InstanceName("License Info")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class LicenseInfoRow : Row<LicenseInfoRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Regkey"), Size(50), QuickSearch, NameProperty]
        public String Regkey
        {
            get => fields.Regkey[this];
            set => fields.Regkey[this] = value;
        }

        [DisplayName("Company Name"), Size(100), LookupEditor(typeof(Lookups.LincenseInfoCompanyNameLookup), AutoComplete = true)]
        public String CompanyName
        {
            get => fields.CompanyName[this];
            set => fields.CompanyName[this] = value;
        }

        [DisplayName("Company Group Id"), Column("CompanyGroupID"), Size(100)]
        public String CompanyGroupId
        {
            get => fields.CompanyGroupId[this];
            set => fields.CompanyGroupId[this] = value;
        }

        [DisplayName("Company Roc"), Size(50)]
        public String CompanyRoc
        {
            get => fields.CompanyRoc[this];
            set => fields.CompanyRoc[this] = value;
        }

        [DisplayName("Address 1"), Size(100)]
        public String Address1
        {
            get => fields.Address1[this];
            set => fields.Address1[this] = value;
        }

        [DisplayName("Address 2"), Size(100)]
        public String Address2
        {
            get => fields.Address2[this];
            set => fields.Address2[this] = value;
        }

        [DisplayName("Address 3"), Size(100)]
        public String Address3
        {
            get => fields.Address3[this];
            set => fields.Address3[this] = value;
        }

        [DisplayName("Address 4"), Size(100)]
        public String Address4
        {
            get => fields.Address4[this];
            set => fields.Address4[this] = value;
        }

        [DisplayName("Telephone"), Size(50)]
        public String Telephone
        {
            get => fields.Telephone[this];
            set => fields.Telephone[this] = value;
        }

        [DisplayName("Fax"), Size(50)]
        public String Fax
        {
            get => fields.Fax[this];
            set => fields.Fax[this] = value;
        }

        [DisplayName("Email"), Size(50),LookupEditor(typeof(Lookups.LincenseInfoEmailLookup), AutoComplete = true)]
        public String Email
        {
            get => fields.Email[this];
            set => fields.Email[this] = value;
        }

        [DisplayName("Website"), Size(100)]
        public String Website
        {
            get => fields.Website[this];
            set => fields.Website[this] = value;
        }

        [DisplayName("Contact Person"), Size(100)]
        public String ContactPerson
        {
            get => fields.ContactPerson[this];
            set => fields.ContactPerson[this] = value;
        }

        [DisplayName("Business"), Size(100)]
        public String Business
        {
            get => fields.Business[this];
            set => fields.Business[this] = value;
        }

        [DisplayName("Serial Key"), Size(50), PrimaryKey, IdProperty]
        public String SerialKey
        {
            get => fields.SerialKey[this];
            set => fields.SerialKey[this] = value;
        }

        [DisplayName("Card Group"), Size(10)]
        public String CardGroup
        {
            get => fields.CardGroup[this];
            set => fields.CardGroup[this] = value;
        }

        [DisplayName("Dealer Id"), Size(20), LookupEditor(typeof(Lookups.LincenseInfoDealerIdLookup), AutoComplete = true)]
        public String DealerId
        {
            get => fields.DealerId[this];
            set => fields.DealerId[this] = value;
        }

        [DisplayName("Dealer Company"), Size(100), LookupEditor(typeof(Lookups.LincenseInfoDealerCompanyLookup), AutoComplete = true)]
        public String DealerCompany
        {
            get => fields.DealerCompany[this];
            set => fields.DealerCompany[this] = value;
        }

        [DisplayName("Dealer Contact"), Size(100)]
        public String DealerContact
        {
            get => fields.DealerContact[this];
            set => fields.DealerContact[this] = value;
        }

        [DisplayName("Dealer Telephone"), Size(50)]
        public String DealerTelephone
        {
            get => fields.DealerTelephone[this];
            set => fields.DealerTelephone[this] = value;
        }

        [DisplayName("Dealer Fax"), Size(50)]
        public String DealerFax
        {
            get => fields.DealerFax[this];
            set => fields.DealerFax[this] = value;
        }

        [DisplayName("Dealer Email"), Size(50), LookupEditor(typeof(Lookups.LincenseInfoDealerEmailLookup), AutoComplete = true)]
        public String DealerEmail
        {
            get => fields.DealerEmail[this];
            set => fields.DealerEmail[this] = value;
        }

        [DisplayName("Dealer Website"), Size(100)]
        public String DealerWebsite
        {
            get => fields.DealerWebsite[this];
            set => fields.DealerWebsite[this] = value;
        }

        [DisplayName("Country Id"), Column("CountryID"), Size(20)]
        public String CountryId
        {
            get => fields.CountryId[this];
            set => fields.CountryId[this] = value;
        }

        [DisplayName("Signature Id"), Size(150)]
        public String SignatureId
        {
            get => fields.SignatureId[this];
            set => fields.SignatureId[this] = value;
        }

        [DisplayName("License Key"), Size(150)]
        public String LicenseKey
        {
            get => fields.LicenseKey[this];
            set => fields.LicenseKey[this] = value;
        }

        [DisplayName("Productcode"), Size(50)]
        public String Productcode
        {
            get => fields.Productcode[this];
            set => fields.Productcode[this] = value;
        }

        [DisplayName("Product Description"), Size(100), LookupEditor(typeof(Lookups.LincenseInfoProductDescriptionLookup), AutoComplete = true)]
        public String ProductDescription
        {
            get => fields.ProductDescription[this];
            set => fields.ProductDescription[this] = value;
        }

        [DisplayName("Date Purchase")]
        public DateTime? DatePurchase
        {
            get => fields.DatePurchase[this];
            set => fields.DatePurchase[this] = value;
        }

        [DisplayName("Activate Date")]
        public DateTime? ActivateDate
        {
            get => fields.ActivateDate[this];
            set => fields.ActivateDate[this] = value;
        }

        [DisplayName("Remark"), Size(200)]
        public String Remark
        {
            get => fields.Remark[this];
            set => fields.Remark[this] = value;
        }

        [DisplayName("Security Code"), Size(50)]
        public String SecurityCode
        {
            get => fields.SecurityCode[this];
            set => fields.SecurityCode[this] = value;
        }

        [DisplayName("Security Code Gen By"), Size(50)]
        public String SecurityCodeGenBy
        {
            get => fields.SecurityCodeGenBy[this];
            set => fields.SecurityCodeGenBy[this] = value;
        }

        [DisplayName("Security Code Gen Date")]
        public DateTime? SecurityCodeGenDate
        {
            get => fields.SecurityCodeGenDate[this];
            set => fields.SecurityCodeGenDate[this] = value;
        }

        [DisplayName("Partner Remark"), Size(500)]
        public String PartnerRemark
        {
            get => fields.PartnerRemark[this];
            set => fields.PartnerRemark[this] = value;
        }

        [DisplayName("Transfer To"), Size(50)]
        public String TransferTo
        {
            get => fields.TransferTo[this];
            set => fields.TransferTo[this] = value;
        }

        [DisplayName("Transfer By"), Size(50)]
        public String TransferBy
        {
            get => fields.TransferBy[this];
            set => fields.TransferBy[this] = value;
        }

        [DisplayName("Transfer Date")]
        public DateTime? TransferDate
        {
            get => fields.TransferDate[this];
            set => fields.TransferDate[this] = value;
        }

        [DisplayName("Transfer Remark"), Size(200)]
        public String TransferRemark
        {
            get => fields.TransferRemark[this];
            set => fields.TransferRemark[this] = value;
        }

        [DisplayName("Cover For Serial Key"), Size(50)]
        public String CoverForSerialKey
        {
            get => fields.CoverForSerialKey[this];
            set => fields.CoverForSerialKey[this] = value;
        }

        [DisplayName("Cover Expiry Date")]
        public DateTime? CoverExpiryDate
        {
            get => fields.CoverExpiryDate[this];
            set => fields.CoverExpiryDate[this] = value;
        }

        [DisplayName("Cover Activate By"), Size(50)]
        public String CoverActivateBy
        {
            get => fields.CoverActivateBy[this];
            set => fields.CoverActivateBy[this] = value;
        }

        [DisplayName("Cover Activate Date")]
        public DateTime? CoverActivateDate
        {
            get => fields.CoverActivateDate[this];
            set => fields.CoverActivateDate[this] = value;
        }

        [DisplayName("Cover Version")]
        public Int32? CoverVersion
        {
            get => fields.CoverVersion[this];
            set => fields.CoverVersion[this] = value;
        }

        [DisplayName("Is Block"), Size(1)]
        public String IsBlock
        {
            get => fields.IsBlock[this];
            set => fields.IsBlock[this] = value;
        }

        [DisplayName("Block By"), Size(50)]
        public String BlockBy
        {
            get => fields.BlockBy[this];
            set => fields.BlockBy[this] = value;
        }

        [DisplayName("Block Create Date")]
        public DateTime? BlockCreateDate
        {
            get => fields.BlockCreateDate[this];
            set => fields.BlockCreateDate[this] = value;
        }

        [DisplayName("Block From Date")]
        public DateTime? BlockFromDate
        {
            get => fields.BlockFromDate[this];
            set => fields.BlockFromDate[this] = value;
        }

        [DisplayName("Block Remark"), Size(200)]
        public String BlockRemark
        {
            get => fields.BlockRemark[this];
            set => fields.BlockRemark[this] = value;
        }

        [DisplayName("Msg Id"), Size(20)]
        public String MsgId
        {
            get => fields.MsgId[this];
            set => fields.MsgId[this] = value;
        }

        [DisplayName("Is Void"), Size(1)]
        public String IsVoid
        {
            get => fields.IsVoid[this];
            set => fields.IsVoid[this] = value;
        }

        [DisplayName("Void By"), Size(50)]
        public String VoidBy
        {
            get => fields.VoidBy[this];
            set => fields.VoidBy[this] = value;
        }

        [DisplayName("Void Date")]
        public DateTime? VoidDate
        {
            get => fields.VoidDate[this];
            set => fields.VoidDate[this] = value;
        }

        [DisplayName("Void Remark"), Size(200)]
        public String VoidRemark
        {
            get => fields.VoidRemark[this];
            set => fields.VoidRemark[this] = value;
        }

        [DisplayName("Is Activate"), Size(1)]
        public String IsActivate
        {
            get => fields.IsActivate[this];
            set => fields.IsActivate[this] = value;
        }

        [DisplayName("Is License Ready"), Size(1)]
        public String IsLicenseReady
        {
            get => fields.IsLicenseReady[this];
            set => fields.IsLicenseReady[this] = value;
        }

        [DisplayName("License Key V1"), Size(150)]
        public String LicenseKeyV1
        {
            get => fields.LicenseKeyV1[this];
            set => fields.LicenseKeyV1[this] = value;
        }

        [DisplayName("Force Recertify Date")]
        public DateTime? ForceRecertifyDate
        {
            get => fields.ForceRecertifyDate[this];
            set => fields.ForceRecertifyDate[this] = value;
        }

        [DisplayName("Reserve For"), Size(100)]
        public String ReserveFor
        {
            get => fields.ReserveFor[this];
            set => fields.ReserveFor[this] = value;
        }

        [DisplayName("Sub Dealer Id"), Size(20)]
        public String SubDealerId
        {
            get => fields.SubDealerId[this];
            set => fields.SubDealerId[this] = value;
        }

        [DisplayName("Is Cover Plus"), Size(1)]
        public String IsCoverPlus
        {
            get => fields.IsCoverPlus[this];
            set => fields.IsCoverPlus[this] = value;
        }

        [DisplayName("Two In One Key"), Size(1)]
        public String TwoInOneKey
        {
            get => fields.TwoInOneKey[this];
            set => fields.TwoInOneKey[this] = value;
        }

        public LicenseInfoRow()
            : base()
        {
        }

        public LicenseInfoRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField Regkey;
            public StringField CompanyName;
            public StringField CompanyGroupId;
            public StringField CompanyRoc;
            public StringField Address1;
            public StringField Address2;
            public StringField Address3;
            public StringField Address4;
            public StringField Telephone;
            public StringField Fax;
            public StringField Email;
            public StringField Website;
            public StringField ContactPerson;
            public StringField Business;
            public StringField SerialKey;
            public StringField CardGroup;
            public StringField DealerId;
            public StringField DealerCompany;
            public StringField DealerContact;
            public StringField DealerTelephone;
            public StringField DealerFax;
            public StringField DealerEmail;
            public StringField DealerWebsite;
            public StringField CountryId;
            public StringField SignatureId;
            public StringField LicenseKey;
            public StringField Productcode;
            public StringField ProductDescription;
            public DateTimeField DatePurchase;
            public DateTimeField ActivateDate;
            public StringField Remark;
            public StringField SecurityCode;
            public StringField SecurityCodeGenBy;
            public DateTimeField SecurityCodeGenDate;
            public StringField PartnerRemark;
            public StringField TransferTo;
            public StringField TransferBy;
            public DateTimeField TransferDate;
            public StringField TransferRemark;
            public StringField CoverForSerialKey;
            public DateTimeField CoverExpiryDate;
            public StringField CoverActivateBy;
            public DateTimeField CoverActivateDate;
            public Int32Field CoverVersion;
            public StringField IsBlock;
            public StringField BlockBy;
            public DateTimeField BlockCreateDate;
            public DateTimeField BlockFromDate;
            public StringField BlockRemark;
            public StringField MsgId;
            public StringField IsVoid;
            public StringField VoidBy;
            public DateTimeField VoidDate;
            public StringField VoidRemark;
            public StringField IsActivate;
            public StringField IsLicenseReady;
            public StringField LicenseKeyV1;
            public DateTimeField ForceRecertifyDate;
            public StringField ReserveFor;
            public StringField SubDealerId;
            public StringField IsCoverPlus;
            public StringField TwoInOneKey;
        }
    }
}
