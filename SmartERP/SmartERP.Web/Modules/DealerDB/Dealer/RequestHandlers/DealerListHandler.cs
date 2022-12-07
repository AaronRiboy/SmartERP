using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.DealerDB.DealerRow>;
using MyRow = SmartERP.DealerDB.DealerRow;

namespace SmartERP.DealerDB
{
    public interface IDealerListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class DealerListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDealerListHandler
    {
        public DealerListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}