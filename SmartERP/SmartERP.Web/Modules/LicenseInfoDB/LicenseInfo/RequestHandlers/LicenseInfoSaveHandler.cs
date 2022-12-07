using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.LicenseInfoDB.LicenseInfoRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.LicenseInfoDB.LicenseInfoRow;

namespace SmartERP.LicenseInfoDB
{
    public interface ILicenseInfoSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class LicenseInfoSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILicenseInfoSaveHandler
    {
        public LicenseInfoSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}