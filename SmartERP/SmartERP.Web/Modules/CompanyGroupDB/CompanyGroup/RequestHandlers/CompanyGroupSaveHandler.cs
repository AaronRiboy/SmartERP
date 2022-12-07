using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.CompanyGroupDB.CompanyGroupRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.CompanyGroupDB.CompanyGroupRow;

namespace SmartERP.CompanyGroupDB
{
    public interface ICompanyGroupSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CompanyGroupSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICompanyGroupSaveHandler
    {
        public CompanyGroupSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}