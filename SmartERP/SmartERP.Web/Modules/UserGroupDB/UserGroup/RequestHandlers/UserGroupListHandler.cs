using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.UserGroupDB.UserGroupRow>;
using MyRow = SmartERP.UserGroupDB.UserGroupRow;

namespace SmartERP.UserGroupDB
{
    public interface IUserGroupListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class UserGroupListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserGroupListHandler
    {
        public UserGroupListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}