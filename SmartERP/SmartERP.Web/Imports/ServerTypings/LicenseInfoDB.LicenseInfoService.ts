namespace SmartERP.LicenseInfoDB {
    export namespace LicenseInfoService {
        export const baseUrl = 'LicenseInfoDB/LicenseInfo';

        export declare function Create(request: Serenity.SaveRequest<LicenseInfoRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<LicenseInfoRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<LicenseInfoRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<LicenseInfoRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "LicenseInfoDB/LicenseInfo/Create",
            Update = "LicenseInfoDB/LicenseInfo/Update",
            Delete = "LicenseInfoDB/LicenseInfo/Delete",
            Retrieve = "LicenseInfoDB/LicenseInfo/Retrieve",
            List = "LicenseInfoDB/LicenseInfo/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>LicenseInfoService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
