using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.CountryDB.CountryRow>;
using MyRow = SmartERP.CountryDB.CountryRow;

namespace SmartERP.CountryDB
{
    public interface ICountryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CountryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICountryRetrieveHandler
    {
        public CountryRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}