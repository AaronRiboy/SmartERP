using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.BusinessNatureDB.Forms
{
    [FormScript("BusinessNatureDB.BusinessNature")]
    [BasedOnRow(typeof(BusinessNatureRow), CheckNames = true)]
    public class BusinessNatureForm
    {
        public String AcBusinessNatureDesc { get; set; }
        public Int32 OrderNo { get; set; }
        public String CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public String EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public Int32 Stamp { get; set; }
        public String AcBusinessNatureGrpId { get; set; }
    }
}