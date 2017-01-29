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
        GenreList?: number[];
        CastList?: MovieCastRow[];
        PrimaryImage?: string;
        GalleryImages?: string;
        TenantId?: number;
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
            export declare const GenreList: string;
            export declare const CastList: string;
            export declare const PrimaryImage: string;
            export declare const GalleryImages: string;
            export declare const TenantId: string;
        }

        ['MovieId', 'Title', 'Description', 'Storyline', 'ReleaseYear', 'ReleaseDate', 'Runtime', 'Kind', 'GenreList', 'CastList', 'PrimaryImage', 'GalleryImages', 'TenantId'].forEach(x => (<any>Fields)[x] = x);
    }
}

