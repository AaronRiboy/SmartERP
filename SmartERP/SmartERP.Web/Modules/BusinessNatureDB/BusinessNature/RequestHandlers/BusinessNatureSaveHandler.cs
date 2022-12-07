using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.BusinessNatureDB.BusinessNatureRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.BusinessNatureDB.BusinessNatureRow;

namespace SmartERP.BusinessNatureDB
{
    public interface IBusinessNatureSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class BusinessNatureSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBusinessNatureSaveHandler
    {
        public BusinessNatureSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}