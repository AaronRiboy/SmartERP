using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.UserGroupDB.UserGroupRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.UserGroupDB.UserGroupRow;

namespace SmartERP.UserGroupDB
{
    public interface IUserGroupSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class UserGroupSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IUserGroupSaveHandler
    {
        public UserGroupSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}