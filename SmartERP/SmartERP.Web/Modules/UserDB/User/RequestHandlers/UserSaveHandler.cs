using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.UserDB.UserRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.UserDB.UserRow;

namespace SmartERP.UserDB
{
    public interface IUserSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class UserSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IUserSaveHandler
    {
        public UserSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}