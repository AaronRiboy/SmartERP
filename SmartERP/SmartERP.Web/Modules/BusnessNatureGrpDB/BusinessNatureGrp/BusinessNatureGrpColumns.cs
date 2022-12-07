using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.BusnessNatureGrpDB.Columns
{
    [ColumnsScript("BusnessNatureGrpDB.BusinessNatureGrp")]
    [BasedOnRow(typeof(BusinessNatureGrpRow), CheckNames = true)]
    public class BusinessNatureGrpColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String AcBusinessNatureGrpId { get; set; }
        public String AcBusinessNatureGrpDesc { get; set; }
        public String CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public String EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public Int32 Stamp { get; set; }
    }
}