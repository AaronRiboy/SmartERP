using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.LeadSourceDB.LeadSourceRow>;
using MyRow = SmartERP.LeadSourceDB.LeadSourceRow;

namespace SmartERP.LeadSourceDB
{
    public interface ILeadSourceListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class LeadSourceListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILeadSourceListHandler
    {
        public LeadSourceListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}