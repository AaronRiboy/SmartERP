using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.UserDB.UserRow>;
using MyRow = SmartERP.UserDB.UserRow;

namespace SmartERP.UserDB
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}