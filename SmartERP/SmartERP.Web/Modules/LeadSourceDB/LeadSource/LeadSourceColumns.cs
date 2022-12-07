using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.LeadSourceDB.Columns
{
    [ColumnsScript("LeadSourceDB.LeadSource")]
    [BasedOnRow(typeof(LeadSourceRow), CheckNames = true)]
    public class LeadSourceColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String AcLeadSourceId { get; set; }
        public String AcLeadSourceDesc { get; set; }
        public String CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public String EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public Int32 Stamp { get; set; }
    }
}