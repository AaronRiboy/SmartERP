using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.BusnessNatureGrpDB.BusinessNatureGrpRow;

namespace SmartERP.BusnessNatureGrpDB
{
    public interface IBusinessNatureGrpDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class BusinessNatureGrpDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBusinessNatureGrpDeleteHandler
    {
        public BusinessNatureGrpDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}