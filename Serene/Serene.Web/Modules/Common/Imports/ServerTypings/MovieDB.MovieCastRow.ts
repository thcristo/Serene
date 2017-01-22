namespace Serene.MovieDB {
    export interface MovieCastRow {
        MoviecastId?: number;
        MovieId?: number;
        PersonId?: number;
        MovieCharacter?: string;
        MovieTitle?: string;
        MovieDescription?: string;
        MovieStoryline?: string;
        MovieReleaseYear?: number;
        MovieReleaseDate?: string;
        MovieRuntime?: number;
        MovieKind?: number;
        PersonFirstname?: string;
        PersonLastname?: string;
        PersonFullname?: string;
        PersonBirthdate?: string;
        PersonBirthplace?: string;
        PersonGender?: number;
        PersonHeight?: number;
    }

    export namespace MovieCastRow {
        export const idProperty = 'MoviecastId';
        export const nameProperty = 'MovieCharacter';
        export const localTextPrefix = 'MovieDB.MovieCast';

        export namespace Fields {
            export declare const MoviecastId: string;
            export declare const MovieId: string;
            export declare const PersonId: string;
            export declare const MovieCharacter: string;
            export declare const MovieTitle: string;
            export declare const MovieDescription: string;
            export declare const MovieStoryline: string;
            export declare const MovieReleaseYear: string;
            export declare const MovieReleaseDate: string;
            export declare const MovieRuntime: string;
            export declare const MovieKind: string;
            export declare const PersonFirstname: string;
            export declare const PersonLastname: string;
            export declare const PersonFullname: string;
            export declare const PersonBirthdate: string;
            export declare const PersonBirthplace: string;
            export declare const PersonGender: string;
            export declare const PersonHeight: string;
        }

        ['MoviecastId', 'MovieId', 'PersonId', 'MovieCharacter', 'MovieTitle', 'MovieDescription', 'MovieStoryline', 'MovieReleaseYear', 'MovieReleaseDate', 'MovieRuntime', 'MovieKind', 'PersonFirstname', 'PersonLastname', 'PersonFullname', 'PersonBirthdate', 'PersonBirthplace', 'PersonGender', 'PersonHeight'].forEach(x => (<any>Fields)[x] = x);
    }
}

