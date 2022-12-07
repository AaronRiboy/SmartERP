using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.BusnessNatureGrpDB.Forms
{
    [FormScript("BusnessNatureGrpDB.BusinessNatureGrp")]
    [BasedOnRow(typeof(BusinessNatureGrpRow), CheckNames = true)]
    public class BusinessNatureGrpForm
    {
        public String AcBusinessNatureGrpDesc { get; set; }
        public String CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public String EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public Int32 Stamp { get; set; }
    }
}