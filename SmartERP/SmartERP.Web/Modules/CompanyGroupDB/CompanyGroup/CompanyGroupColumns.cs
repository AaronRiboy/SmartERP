using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.CompanyGroupDB.Columns
{
    [ColumnsScript("CompanyGroupDB.CompanyGroup")]
    [BasedOnRow(typeof(CompanyGroupRow), CheckNames = true)]
    public class CompanyGroupColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String AcCompanyGroupId { get; set; }
        public String AcCompanyGroupDesc { get; set; }
        public String DealerId { get; set; }
        public String CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public String EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public Int32 Stamp { get; set; }
        public String Active { get; set; }
        public String ContactPerson { get; set; }
        public String ContactEmail { get; set; }
        public String ContactNo { get; set; }
        public DateTime SlcRenewDate { get; set; }
        public DateTime SlcExpiryDate { get; set; }
        public String Remark { get; set; }
        public Decimal SlcAmount { get; set; }
        public Int32 TotalInCardMember { get; set; }
        public DateTime LastFollowUpDate { get; set; }
        public Int32 TotalPos { get; set; }
        public Int32 NumberOfOutlet { get; set; }
        public String IntegrationTo { get; set; }
        public String AcBusinessNatureId { get; set; }
        public String AcCustomerStatusId { get; set; }
        public String Masterdealer { get; set; }
    }
}