using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.DealerDB.DealerRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.DealerDB.DealerRow;

namespace SmartERP.DealerDB
{
    public interface IDealerSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class DealerSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDealerSaveHandler
    {
        public DealerSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}