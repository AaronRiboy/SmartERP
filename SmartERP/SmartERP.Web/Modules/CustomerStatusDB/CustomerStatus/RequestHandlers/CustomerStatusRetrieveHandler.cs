using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.CustomerStatusDB.CustomerStatusRow>;
using MyRow = SmartERP.CustomerStatusDB.CustomerStatusRow;

namespace SmartERP.CustomerStatusDB
{
    public interface ICustomerStatusRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerStatusRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerStatusRetrieveHandler
    {
        public CustomerStatusRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}