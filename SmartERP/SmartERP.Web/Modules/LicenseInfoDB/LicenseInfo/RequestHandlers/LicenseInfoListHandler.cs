﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.LicenseInfoDB.LicenseInfoRow>;
using MyRow = SmartERP.LicenseInfoDB.LicenseInfoRow;

namespace SmartERP.LicenseInfoDB
{
    public interface ILicenseInfoListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class LicenseInfoListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILicenseInfoListHandler
    {
        public LicenseInfoListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}