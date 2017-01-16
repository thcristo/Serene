
namespace Serene.MovieDB.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("MovieGenres"), InstanceName("MovieGenres"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MovieGenresRow : Row, IIdRow
    {
        [DisplayName("Movie Genre Id"), Column("MOVIE_GENRE_ID"), Identity]
        public Int32? MovieGenreId
        {
            get { return Fields.MovieGenreId[this]; }
            set { Fields.MovieGenreId[this] = value; }
        }

        [DisplayName("Movie"), Column("MOVIE_ID"), NotNull, ForeignKey("MOVIE", "MOVIE_ID", "MovieDB"), LeftJoin("jMovie"), TextualField("MovieTitle")]
        public Int32? MovieId
        {
            get { return Fields.MovieId[this]; }
            set { Fields.MovieId[this] = value; }
        }

        [DisplayName("Genre"), Column("GENRE_ID"), NotNull, ForeignKey("GENRE", "GENRE_ID", "MovieDB"), LeftJoin("jGenre"), TextualField("GenreName")]
        public Int32? GenreId
        {
            get { return Fields.GenreId[this]; }
            set { Fields.GenreId[this] = value; }
        }

        [DisplayName("Movie Title"), Expression("jMovie.[TITLE]")]
        public String MovieTitle
        {
            get { return Fields.MovieTitle[this]; }
            set { Fields.MovieTitle[this] = value; }
        }

        [DisplayName("Movie Description"), Expression("jMovie.[DESCRIPTION]")]
        public String MovieDescription
        {
            get { return Fields.MovieDescription[this]; }
            set { Fields.MovieDescription[this] = value; }
        }

        [DisplayName("Movie Storyline"), Expression("jMovie.[STORYLINE]")]
        public String MovieStoryline
        {
            get { return Fields.MovieStoryline[this]; }
            set { Fields.MovieStoryline[this] = value; }
        }

        [DisplayName("Movie Release Year"), Expression("jMovie.[RELEASE_YEAR]")]
        public Int32? MovieReleaseYear
        {
            get { return Fields.MovieReleaseYear[this]; }
            set { Fields.MovieReleaseYear[this] = value; }
        }

        [DisplayName("Movie Release Date"), Expression("jMovie.[RELEASE_DATE]")]
        public DateTime? MovieReleaseDate
        {
            get { return Fields.MovieReleaseDate[this]; }
            set { Fields.MovieReleaseDate[this] = value; }
        }

        [DisplayName("Movie Runtime"), Expression("jMovie.[RUNTIME]")]
        public Int32? MovieRuntime
        {
            get { return Fields.MovieRuntime[this]; }
            set { Fields.MovieRuntime[this] = value; }
        }

        [DisplayName("Movie Kind"), Expression("jMovie.[KIND]")]
        public Int32? MovieKind
        {
            get { return Fields.MovieKind[this]; }
            set { Fields.MovieKind[this] = value; }
        }

        [DisplayName("Genre Name"), Expression("jGenre.[NAME]")]
        public String GenreName
        {
            get { return Fields.GenreName[this]; }
            set { Fields.GenreName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.MovieGenreId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MovieGenresRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieGenreId;
            public Int32Field MovieId;
            public Int32Field GenreId;

            public StringField MovieTitle;
            public StringField MovieDescription;
            public StringField MovieStoryline;
            public Int32Field MovieReleaseYear;
            public DateTimeField MovieReleaseDate;
            public Int32Field MovieRuntime;
            public Int32Field MovieKind;

            public StringField GenreName;

            public RowFields()
                : base("MOVIE_GENRES","MovieDB")
            {
                LocalTextPrefix = "MovieDB.MovieGenres";
            }
        }
    }
}
