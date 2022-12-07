using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.BusinessNatureDB.BusinessNatureRow>;
using MyRow = SmartERP.BusinessNatureDB.BusinessNatureRow;

namespace SmartERP.BusinessNatureDB
{
    public interface IBusinessNatureListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BusinessNatureListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBusinessNatureListHandler
    {
        public BusinessNatureListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}