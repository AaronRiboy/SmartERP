using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.LicenseInfoDB.LicenseInfoRow>;
using MyRow = SmartERP.LicenseInfoDB.LicenseInfoRow;

namespace SmartERP.LicenseInfoDB
{
    public interface ILicenseInfoRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class LicenseInfoRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILicenseInfoRetrieveHandler
    {
        public LicenseInfoRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}