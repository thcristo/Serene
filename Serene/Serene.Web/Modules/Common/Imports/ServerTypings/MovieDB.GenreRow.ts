
namespace Serene.MovieDB {
    export interface GenreRow {
        GenreId?: number;
        Name?: string;
    }

    export namespace GenreRow {
        export const idProperty = 'GenreId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'MovieDB.Genre';

        export namespace Fields {
            export declare const GenreId;
            export declare const Name;
        }

        ['GenreId', 'Name'].forEach(x => (<any>Fields)[x] = x);
    }
}

