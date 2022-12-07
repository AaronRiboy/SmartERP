﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.CompanyGroupDB.CompanyGroupRow>;
using MyRow = SmartERP.CompanyGroupDB.CompanyGroupRow;

namespace SmartERP.CompanyGroupDB
{
    public interface ICompanyGroupRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CompanyGroupRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICompanyGroupRetrieveHandler
    {
        public CompanyGroupRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}