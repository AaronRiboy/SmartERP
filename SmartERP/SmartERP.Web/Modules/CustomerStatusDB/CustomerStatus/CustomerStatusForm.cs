using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.CustomerStatusDB.Forms
{
    [FormScript("CustomerStatusDB.CustomerStatus")]
    [BasedOnRow(typeof(CustomerStatusRow), CheckNames = true)]
    public class CustomerStatusForm
    {
        public String AcCustomerStatusDesc { get; set; }
        public String CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public String EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public Int32 Stamp { get; set; }
    }
}