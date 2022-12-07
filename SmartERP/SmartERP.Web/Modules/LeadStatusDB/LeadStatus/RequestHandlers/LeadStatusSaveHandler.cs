using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.LeadStatusDB.LeadStatusRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.LeadStatusDB.LeadStatusRow;

namespace SmartERP.LeadStatusDB
{
    public interface ILeadStatusSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class LeadStatusSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILeadStatusSaveHandler
    {
        public LeadStatusSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}