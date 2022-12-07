using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.LicenseInfoDB.Forms
{
    [FormScript("LicenseInfoDB.LicenseInfo")]
    [BasedOnRow(typeof(LicenseInfoRow), CheckNames = true)]
    public class LicenseInfoForm
    {
        public String Regkey { get; set; }
        public String CompanyName { get; set; }
        public String CompanyGroupId { get; set; }
        public String CompanyRoc { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String Address3 { get; set; }
        public String Address4 { get; set; }
        public String Telephone { get; set; }
        public String Fax { get; set; }
        public String Email { get; set; }
        public String Website { get; set; }
        public String ContactPerson { get; set; }
        public String Business { get; set; }
        public String CardGroup { get; set; }
        public String DealerId { get; set; }
        public String DealerCompany { get; set; }
        public String DealerContact { get; set; }
        public String DealerTelephone { get; set; }
        public String DealerFax { get; set; }
        public String DealerEmail { get; set; }
        public String DealerWebsite { get; set; }
        public String CountryId { get; set; }
        public String SignatureId { get; set; }
        public String LicenseKey { get; set; }
        public String Productcode { get; set; }
        public String ProductDescription { get; set; }
        public DateTime DatePurchase { get; set; }
        public DateTime ActivateDate { get; set; }
        public String Remark { get; set; }
        public String SecurityCode { get; set; }
        public String SecurityCodeGenBy { get; set; }
        public DateTime SecurityCodeGenDate { get; set; }
        public String PartnerRemark { get; set; }
        public String TransferTo { get; set; }
        public String TransferBy { get; set; }
        public DateTime TransferDate { get; set; }
        public String TransferRemark { get; set; }
        public String CoverForSerialKey { get; set; }
        public DateTime CoverExpiryDate { get; set; }
        public String CoverActivateBy { get; set; }
        public DateTime CoverActivateDate { get; set; }
        public Int32 CoverVersion { get; set; }
        public String IsBlock { get; set; }
        public String BlockBy { get; set; }
        public DateTime BlockCreateDate { get; set; }
        public DateTime BlockFromDate { get; set; }
        public String BlockRemark { get; set; }
        public String MsgId { get; set; }
        public String IsVoid { get; set; }
        public String VoidBy { get; set; }
        public DateTime VoidDate { get; set; }
        public String VoidRemark { get; set; }
        public String IsActivate { get; set; }
        public String IsLicenseReady { get; set; }
        public String LicenseKeyV1 { get; set; }
        public DateTime ForceRecertifyDate { get; set; }
        public String ReserveFor { get; set; }
        public String SubDealerId { get; set; }
        public String IsCoverPlus { get; set; }
        public String TwoInOneKey { get; set; }
    }
}