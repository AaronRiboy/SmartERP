using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.BusnessNatureGrpDB.BusinessNatureGrpRow>;
using MyRow = SmartERP.BusnessNatureGrpDB.BusinessNatureGrpRow;

namespace SmartERP.BusnessNatureGrpDB
{
    public interface IBusinessNatureGrpRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class BusinessNatureGrpRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBusinessNatureGrpRetrieveHandler
    {
        public BusinessNatureGrpRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}