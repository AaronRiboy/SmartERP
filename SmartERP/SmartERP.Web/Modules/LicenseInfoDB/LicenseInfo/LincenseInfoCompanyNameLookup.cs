
namespace SmartERP.Lookups
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Demo.Northwind;
    using Serenity.Web;
    using SmartERP.Administration.Entities;
    using SmartERP.LicenseInfoDB;

    [LookupScript, Module("LicenseInfoDB")]
    public class LincenseInfoCompanyNameLookup : RowLookupScript<LicenseInfoRow>
    {
        public LincenseInfoCompanyNameLookup(ISqlConnections sqlConnections)
          : base(sqlConnections)
        {
            IdField = TextField = LicenseInfoRow.Fields.CompanyName.PropertyName;
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            query.Select(LicenseInfoRow.Fields.CompanyName);
        }

    }
}
