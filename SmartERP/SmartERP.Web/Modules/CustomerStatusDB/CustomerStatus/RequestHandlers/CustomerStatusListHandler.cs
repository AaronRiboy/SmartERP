using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.CustomerStatusDB.CustomerStatusRow>;
using MyRow = SmartERP.CustomerStatusDB.CustomerStatusRow;

namespace SmartERP.CustomerStatusDB
{
    public interface ICustomerStatusListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerStatusListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerStatusListHandler
    {
        public CustomerStatusListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}