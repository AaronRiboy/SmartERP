using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.SalesPersonDB.SalesPersonRow;

namespace SmartERP.SalesPersonDB
{
    public interface ISalesPersonDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesPersonDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISalesPersonDeleteHandler
    {
        public SalesPersonDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}