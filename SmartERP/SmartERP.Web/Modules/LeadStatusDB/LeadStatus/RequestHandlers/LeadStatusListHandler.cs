using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.LeadStatusDB.LeadStatusRow>;
using MyRow = SmartERP.LeadStatusDB.LeadStatusRow;

namespace SmartERP.LeadStatusDB
{
    public interface ILeadStatusListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class LeadStatusListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILeadStatusListHandler
    {
        public LeadStatusListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}