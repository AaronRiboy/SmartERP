using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.UserGroupDB.UserGroupRow>;
using MyRow = SmartERP.UserGroupDB.UserGroupRow;

namespace SmartERP.UserGroupDB
{
    public interface IUserGroupRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class UserGroupRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUserGroupRetrieveHandler
    {
        public UserGroupRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}