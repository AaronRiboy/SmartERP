using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.LeadSourceDB.LeadSourceRow>;
using MyRow = SmartERP.LeadSourceDB.LeadSourceRow;

namespace SmartERP.LeadSourceDB
{
    public interface ILeadSourceRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class LeadSourceRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILeadSourceRetrieveHandler
    {
        public LeadSourceRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}