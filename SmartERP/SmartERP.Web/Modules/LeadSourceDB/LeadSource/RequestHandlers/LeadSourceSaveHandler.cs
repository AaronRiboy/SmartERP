using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.LeadSourceDB.LeadSourceRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.LeadSourceDB.LeadSourceRow;

namespace SmartERP.LeadSourceDB
{
    public interface ILeadSourceSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class LeadSourceSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILeadSourceSaveHandler
    {
        public LeadSourceSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}