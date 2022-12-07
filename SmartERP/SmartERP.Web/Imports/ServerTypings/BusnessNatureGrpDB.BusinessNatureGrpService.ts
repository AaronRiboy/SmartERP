namespace SmartERP.BusnessNatureGrpDB {
    export namespace BusinessNatureGrpService {
        export const baseUrl = 'BusnessNatureGrpDB/BusinessNatureGrp';

        export declare function Create(request: Serenity.SaveRequest<BusinessNatureGrpRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<BusinessNatureGrpRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<BusinessNatureGrpRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<BusinessNatureGrpRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "BusnessNatureGrpDB/BusinessNatureGrp/Create",
            Update = "BusnessNatureGrpDB/BusinessNatureGrp/Update",
            Delete = "BusnessNatureGrpDB/BusinessNatureGrp/Delete",
            Retrieve = "BusnessNatureGrpDB/BusinessNatureGrp/Retrieve",
            List = "BusnessNatureGrpDB/BusinessNatureGrp/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>BusinessNatureGrpService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
