
namespace SmartERP.Lookups
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Demo.Northwind;
    using Serenity.Web;
    using SmartERP.Administration.Entities;
    using SmartERP.LicenseInfoDB;

    [LookupScript, Module("LicenseInfoDB")]
    public class LincenseInfoEmailLookup : RowLookupScript<LicenseInfoRow>
    {
        public LincenseInfoEmailLookup(ISqlConnections sqlConnections)
          : base(sqlConnections)
        {
            IdField = TextField = LicenseInfoRow.Fields.Email.PropertyName;
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            query.Select(LicenseInfoRow.Fields.Email);
        }

    }
}
