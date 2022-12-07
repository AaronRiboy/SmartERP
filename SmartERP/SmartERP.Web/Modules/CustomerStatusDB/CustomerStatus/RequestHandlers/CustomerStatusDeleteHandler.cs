using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.CustomerStatusDB.CustomerStatusRow;

namespace SmartERP.CustomerStatusDB
{
    public interface ICustomerStatusDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerStatusDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerStatusDeleteHandler
    {
        public CustomerStatusDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}