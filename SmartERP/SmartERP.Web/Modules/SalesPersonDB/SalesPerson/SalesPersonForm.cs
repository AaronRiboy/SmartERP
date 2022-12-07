using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.SalesPersonDB.Forms
{
    [FormScript("SalesPersonDB.SalesPerson")]
    [BasedOnRow(typeof(SalesPersonRow), CheckNames = true)]
    public class SalesPersonForm
    {
        public String DealerId { get; set; }
        public String AcSalesPersonId { get; set; }
        public String AcSalesPersonDesc { get; set; }
        public String CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public String EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public Int32 Stamp { get; set; }
    }
}