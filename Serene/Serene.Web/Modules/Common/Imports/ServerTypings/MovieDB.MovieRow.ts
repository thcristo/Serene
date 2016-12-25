
namespace Serene.MovieDB {
    export interface MovieRow {
        MovieId?: number;
        Title?: string;
        Description?: string;
        Storyline?: string;
        ReleaseYear?: number;
        ReleaseDate?: string;
        Runtime?: number;
    }

    export namespace MovieRow {
        export const idProperty = 'MovieId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'MovieDB.Movie';

        export namespace Fields {
            export declare const MovieId;
            export declare const Title;
            export declare const Description;
            export declare const Storyline;
            export declare const ReleaseYear;
            export declare const ReleaseDate;
            export declare const Runtime;
        }

        ['MovieId', 'Title', 'Description', 'Storyline', 'ReleaseYear', 'ReleaseDate', 'Runtime'].forEach(x => (<any>Fields)[x] = x);
    }
}

