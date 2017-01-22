namespace Serene.Administration {
    export interface TenantRow {
        Id?: number;
        Name?: string;
    }

    export namespace TenantRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Administration.Tenant';
        export const lookupKey = 'Administration.Tenant';

        export function getLookup(): Q.Lookup<TenantRow> {
            return Q.getLookup<TenantRow>('Administration.Tenant');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Name: string;
        }

        ['Id', 'Name'].forEach(x => (<any>Fields)[x] = x);
    }
}

