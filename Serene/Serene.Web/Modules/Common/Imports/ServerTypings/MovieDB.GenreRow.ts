﻿namespace Serene.MovieDB {
    export interface GenreRow {
        GenreId?: number;
        Name?: string;
        TenantId?: number;
    }

    export namespace GenreRow {
        export const idProperty = 'GenreId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'MovieDB.Genre';
        export const lookupKey = 'MovieDB.Genre';

        export function getLookup(): Q.Lookup<GenreRow> {
            return Q.getLookup<GenreRow>('MovieDB.Genre');
        }

        export namespace Fields {
            export declare const GenreId: string;
            export declare const Name: string;
            export declare const TenantId: string;
        }

        ['GenreId', 'Name', 'TenantId'].forEach(x => (<any>Fields)[x] = x);
    }
}

