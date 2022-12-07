using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.LeadStatusDB.LeadStatusRow>;
using MyRow = SmartERP.LeadStatusDB.LeadStatusRow;

namespace SmartERP.LeadStatusDB
{
    public interface ILeadStatusRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class LeadStatusRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILeadStatusRetrieveHandler
    {
        public LeadStatusRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}