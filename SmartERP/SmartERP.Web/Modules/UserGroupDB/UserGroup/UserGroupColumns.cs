using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.UserGroupDB.Columns
{
    [ColumnsScript("UserGroupDB.UserGroup")]
    [BasedOnRow(typeof(UserGroupRow), CheckNames = true)]
    public class UserGroupColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String AcUserGroupId { get; set; }
        public String AcUserGroupDesc { get; set; }
        public String IsSmartStaff { get; set; }
        public String CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public String EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public Int32 Stamp { get; set; }
    }
}