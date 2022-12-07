using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.LicenseInfoDB.LicenseInfoRow;

namespace SmartERP.LicenseInfoDB
{
    public interface ILicenseInfoDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class LicenseInfoDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILicenseInfoDeleteHandler
    {
        public LicenseInfoDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}