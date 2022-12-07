using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.LeadSourceDB.LeadSourceRow;

namespace SmartERP.LeadSourceDB
{
    public interface ILeadSourceDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class LeadSourceDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILeadSourceDeleteHandler
    {
        public LeadSourceDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}