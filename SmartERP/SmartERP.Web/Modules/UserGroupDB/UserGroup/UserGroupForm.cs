using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.UserGroupDB.Forms
{
    [FormScript("UserGroupDB.UserGroup")]
    [BasedOnRow(typeof(UserGroupRow), CheckNames = true)]
    public class UserGroupForm
    {
        public String AcUserGroupDesc { get; set; }
        public String IsSmartStaff { get; set; }
        public String CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public String EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public Int32 Stamp { get; set; }
    }
}