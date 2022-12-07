using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.SalesPersonDB.SalesPersonRow>;
using MyRow = SmartERP.SalesPersonDB.SalesPersonRow;

namespace SmartERP.SalesPersonDB
{
    public interface ISalesPersonRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesPersonRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISalesPersonRetrieveHandler
    {
        public SalesPersonRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}