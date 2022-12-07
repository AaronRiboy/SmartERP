using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.LeadStatusDB.Forms
{
    [FormScript("LeadStatusDB.LeadStatus")]
    [BasedOnRow(typeof(LeadStatusRow), CheckNames = true)]
    public class LeadStatusForm
    {
        public String AcLeadStatusDesc { get; set; }
        public String CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public String EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public Int32 Stamp { get; set; }
    }
}