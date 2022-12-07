using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.UserDB.UserRow;

namespace SmartERP.UserDB
{
    public interface IUserDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class UserDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IUserDeleteHandler
    {
        public UserDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}