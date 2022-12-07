using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.DealerDB.DealerRow;

namespace SmartERP.DealerDB
{
    public interface IDealerDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class DealerDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDealerDeleteHandler
    {
        public DealerDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}