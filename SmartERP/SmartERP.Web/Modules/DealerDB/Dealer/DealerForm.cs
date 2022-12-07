using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.DealerDB.Forms
{
    [FormScript("DealerDB.Dealer")]
    [BasedOnRow(typeof(DealerRow), CheckNames = true)]
    public class DealerForm
    {
        public String DealerId { get; set; }
        public String Name { get; set; }
        public String ContactNo { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public String Country { get; set; }
        public String State { get; set; }
        public String City { get; set; }
        public String PostCode { get; set; }
        public String IsSubDealer { get; set; }
        public String Active { get; set; }
        public String CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public String EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public Int32 Stamp { get; set; }
        public String CoverDocNoPreFix { get; set; }
        public Int32 CoverLastDocNo { get; set; }
        public String IsTaxExclusive { get; set; }
    }
}