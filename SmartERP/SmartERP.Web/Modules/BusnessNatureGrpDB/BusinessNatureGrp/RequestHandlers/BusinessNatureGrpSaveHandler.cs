using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.BusnessNatureGrpDB.BusinessNatureGrpRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.BusnessNatureGrpDB.BusinessNatureGrpRow;

namespace SmartERP.BusnessNatureGrpDB
{
    public interface IBusinessNatureGrpSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class BusinessNatureGrpSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBusinessNatureGrpSaveHandler
    {
        public BusinessNatureGrpSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}