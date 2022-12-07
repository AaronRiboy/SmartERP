using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.LeadStatusDB.LeadStatusRow;

namespace SmartERP.LeadStatusDB
{
    public interface ILeadStatusDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class LeadStatusDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILeadStatusDeleteHandler
    {
        public LeadStatusDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}