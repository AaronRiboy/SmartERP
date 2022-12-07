using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.BusinessNatureDB.BusinessNatureRow;

namespace SmartERP.BusinessNatureDB
{
    public interface IBusinessNatureDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class BusinessNatureDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBusinessNatureDeleteHandler
    {
        public BusinessNatureDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}