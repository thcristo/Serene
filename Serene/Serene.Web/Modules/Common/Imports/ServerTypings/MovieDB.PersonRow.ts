namespace Serene.MovieDB {
    export interface PersonRow {
        PersonId?: number;
        Firstname?: string;
        Lastname?: string;
        Fullname?: string;
        Birthdate?: string;
        Birthplace?: string;
        Gender?: Gender;
        Height?: number;
    }

    export namespace PersonRow {
        export const idProperty = 'PersonId';
        export const nameProperty = 'Fullname';
        export const localTextPrefix = 'MovieDB.Person';

        export namespace Fields {
            export declare const PersonId: string;
            export declare const Firstname: string;
            export declare const Lastname: string;
            export declare const Fullname: string;
            export declare const Birthdate: string;
            export declare const Birthplace: string;
            export declare const Gender: string;
            export declare const Height: string;
        }

        ['PersonId', 'Firstname', 'Lastname', 'Fullname', 'Birthdate', 'Birthplace', 'Gender', 'Height'].forEach(x => (<any>Fields)[x] = x);
    }
}

