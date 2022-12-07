using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.BusinessNatureDB.BusinessNatureRow>;
using MyRow = SmartERP.BusinessNatureDB.BusinessNatureRow;

namespace SmartERP.BusinessNatureDB
{
    public interface IBusinessNatureRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class BusinessNatureRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBusinessNatureRetrieveHandler
    {
        public BusinessNatureRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}