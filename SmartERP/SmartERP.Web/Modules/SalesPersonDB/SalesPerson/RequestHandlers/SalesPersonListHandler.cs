using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.SalesPersonDB.SalesPersonRow>;
using MyRow = SmartERP.SalesPersonDB.SalesPersonRow;

namespace SmartERP.SalesPersonDB
{
    public interface ISalesPersonListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesPersonListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISalesPersonListHandler
    {
        public SalesPersonListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}