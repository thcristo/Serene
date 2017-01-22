/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace Serene.MovieDB
{
    @Serenity.Decorators.registerEditor()
    export class MovieCastEditor extends Common.GridEditorBase<MovieCastRow> {
        protected getColumnsKey() { return "MovieDB.MovieCast"; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }
        protected getDialogType() { return MovieCastEditDialog; }

        protected validateEntity(row: MovieCastRow, id: number)
        {
            if (!super.validateEntity(row, id))
                return false;

            row.PersonFullname = PersonRow.getLookup()
                .itemById[row.PersonId].Fullname;

            return true;
        }     

        constructor(container: JQuery)
        {
            super(container);
        }

        protected getAddButtonCaption()
        {
            return "Add";
        }
    }
}