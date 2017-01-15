namespace Serene.MovieDB {
    export interface MovieRow {
        MovieId?: number;
        Title?: string;
        Description?: string;
        Storyline?: string;
        ReleaseYear?: number;
        ReleaseDate?: string;
        Runtime?: number;
        Kind?: MovieKind;
        GenreId?: number;
        GenreName?: string;
    }

    export namespace MovieRow {
        export const idProperty = 'MovieId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'MovieDB.Movie';

        export namespace Fields {
            export declare const MovieId: string;
            export declare const Title: string;
            export declare const Description: string;
            export declare const Storyline: string;
            export declare const ReleaseYear: string;
            export declare const ReleaseDate: string;
            export declare const Runtime: string;
            export declare const Kind: string;
            export declare const GenreId: string;
            export declare const GenreName: string;
        }

        ['MovieId', 'Title', 'Description', 'Storyline', 'ReleaseYear', 'ReleaseDate', 'Runtime', 'Kind', 'GenreId', 'GenreName'].forEach(x => (<any>Fields)[x] = x);
    }
}

