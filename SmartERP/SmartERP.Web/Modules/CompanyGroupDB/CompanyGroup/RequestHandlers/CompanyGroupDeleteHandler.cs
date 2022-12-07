using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.CompanyGroupDB.CompanyGroupRow;

namespace SmartERP.CompanyGroupDB
{
    public interface ICompanyGroupDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CompanyGroupDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICompanyGroupDeleteHandler
    {
        public CompanyGroupDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}