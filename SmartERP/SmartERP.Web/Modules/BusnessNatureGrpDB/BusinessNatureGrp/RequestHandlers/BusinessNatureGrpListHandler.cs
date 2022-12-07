using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.BusnessNatureGrpDB.BusinessNatureGrpRow>;
using MyRow = SmartERP.BusnessNatureGrpDB.BusinessNatureGrpRow;

namespace SmartERP.BusnessNatureGrpDB
{
    public interface IBusinessNatureGrpListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BusinessNatureGrpListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBusinessNatureGrpListHandler
    {
        public BusinessNatureGrpListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}