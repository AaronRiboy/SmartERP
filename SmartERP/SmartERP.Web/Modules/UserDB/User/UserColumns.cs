using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.UserDB.Columns
{
    [ColumnsScript("UserDB.User")]
    [BasedOnRow(typeof(UserRow), CheckNames = true)]
    public class UserColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String AcUserId { get; set; }
        public String DealerId { get; set; }
        public String MasterDealer { get; set; }
        public String AcUserGroupAcUserGroupDesc { get; set; }
        public String PwdLogin { get; set; }
        public String Active { get; set; }
        public String Remark { get; set; }
        public String CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public String EditBy { get; set; }
        public DateTime EditDate { get; set; }
        public Int32 Stamp { get; set; }
        public String IsTaxExclusive { get; set; }
    }
}