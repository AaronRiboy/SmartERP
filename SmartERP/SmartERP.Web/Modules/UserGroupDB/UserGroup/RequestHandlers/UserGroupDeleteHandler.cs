using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.UserGroupDB.UserGroupRow;

namespace SmartERP.UserGroupDB
{
    public interface IUserGroupDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class UserGroupDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IUserGroupDeleteHandler
    {
        public UserGroupDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}