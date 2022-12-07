using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.CompanyGroupDB.CompanyGroupRow>;
using MyRow = SmartERP.CompanyGroupDB.CompanyGroupRow;

namespace SmartERP.CompanyGroupDB
{
    public interface ICompanyGroupListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CompanyGroupListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICompanyGroupListHandler
    {
        public CompanyGroupListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}