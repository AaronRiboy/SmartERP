namespace SmartERP.BusinessNatureDB {
    export namespace BusinessNatureService {
        export const baseUrl = 'BusinessNatureDB/BusinessNature';

        export declare function Create(request: Serenity.SaveRequest<BusinessNatureRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<BusinessNatureRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<BusinessNatureRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<BusinessNatureRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "BusinessNatureDB/BusinessNature/Create",
            Update = "BusinessNatureDB/BusinessNature/Update",
            Delete = "BusinessNatureDB/BusinessNature/Delete",
            Retrieve = "BusinessNatureDB/BusinessNature/Retrieve",
            List = "BusinessNatureDB/BusinessNature/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>BusinessNatureService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
