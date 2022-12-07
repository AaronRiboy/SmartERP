using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.SalesPersonDB.SalesPersonRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.SalesPersonDB.SalesPersonRow;

namespace SmartERP.SalesPersonDB
{
    public interface ISalesPersonSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesPersonSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISalesPersonSaveHandler
    {
        public SalesPersonSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}