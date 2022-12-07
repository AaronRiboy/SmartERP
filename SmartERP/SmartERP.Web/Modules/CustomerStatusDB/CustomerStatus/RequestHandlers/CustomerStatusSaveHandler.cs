using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.CustomerStatusDB.CustomerStatusRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.CustomerStatusDB.CustomerStatusRow;

namespace SmartERP.CustomerStatusDB
{
    public interface ICustomerStatusSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerStatusSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerStatusSaveHandler
    {
        public CustomerStatusSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}