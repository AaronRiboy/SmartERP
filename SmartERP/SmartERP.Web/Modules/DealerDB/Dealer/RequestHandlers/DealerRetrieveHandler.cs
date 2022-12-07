using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.DealerDB.DealerRow>;
using MyRow = SmartERP.DealerDB.DealerRow;

namespace SmartERP.DealerDB
{
    public interface IDealerRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class DealerRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDealerRetrieveHandler
    {
        public DealerRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}