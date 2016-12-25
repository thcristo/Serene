
namespace Serene.MovieDB.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("MOVIE"), InstanceName("MOVIE"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Movie Id"), Column("MOVIE_ID"), Identity]
        public Int32? MovieId
        {
            get { return Fields.MovieId[this]; }
            set { Fields.MovieId[this] = value; }
        }

        [DisplayName("Title"), Column("TITLE"), Size(200), NotNull, QuickSearch]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(1000)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Storyline"), Column("STORYLINE")]
        public String Storyline
        {
            get { return Fields.Storyline[this]; }
            set { Fields.Storyline[this] = value; }
        }

        [DisplayName("Release Year"), Column("RELEASE_YEAR")]
        public Int32? ReleaseYear
        {
            get { return Fields.ReleaseYear[this]; }
            set { Fields.ReleaseYear[this] = value; }
        }

        [DisplayName("Release Date"), Column("RELEASE_DATE")]
        public DateTime? ReleaseDate
        {
            get { return Fields.ReleaseDate[this]; }
            set { Fields.ReleaseDate[this] = value; }
        }

        [DisplayName("Runtime"), Column("RUNTIME")]
        public Int32? Runtime
        {
            get { return Fields.Runtime[this]; }
            set { Fields.Runtime[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.MovieId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Title; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MovieRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieId;
            public StringField Title;
            public StringField Description;
            public StringField Storyline;
            public Int32Field ReleaseYear;
            public DateTimeField ReleaseDate;
            public Int32Field Runtime;

            public RowFields()
                : base("MOVIE")
            {
                LocalTextPrefix = "MovieDB.Movie";
            }
        }
    }
}
