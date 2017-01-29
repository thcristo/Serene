
namespace Serene.MovieDB.Entities
{
    using Modules.MovieDB;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Movie Casts"), InstanceName("Cast"), TwoLevelCached]
    [ReadPermission(MovieDBPermissionKeys.Administration)]
    [ModifyPermission(MovieDBPermissionKeys.Administration)]
    public sealed class MovieCastRow : Row, IIdRow, INameRow
    {
        [DisplayName("Moviecast Id"), Column("MOVIECAST_ID"), Identity]
        public Int32? MoviecastId
        {
            get { return Fields.MoviecastId[this]; }
            set { Fields.MoviecastId[this] = value; }
        }

        [DisplayName("Movie"), Column("MOVIE_ID"), NotNull, ForeignKey("MOVIE", "MOVIE_ID", "MovieDB"), LeftJoin("jMovie"), TextualField("MovieTitle")]
        public Int32? MovieId
        {
            get { return Fields.MovieId[this]; }
            set { Fields.MovieId[this] = value; }
        }

        [DisplayName("Actor/Actress"), Column("PERSON_ID"), NotNull, ForeignKey("PERSON", "PERSON_ID", "MovieDB"), LeftJoin("jPerson"), TextualField("PersonFirstname")]
        [LookupEditor(typeof(PersonRow))]
        public Int32? PersonId
        {
            get { return Fields.PersonId[this]; }
            set { Fields.PersonId[this] = value; }
        }

        [DisplayName("Character"), Column("MOVIE_CHARACTER"), Size(50), QuickSearch]
        public String MovieCharacter
        {
            get { return Fields.MovieCharacter[this]; }
            set { Fields.MovieCharacter[this] = value; }
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

        [DisplayName("Person Firstname"), Expression("jPerson.[FIRSTNAME]")]
        public String PersonFirstname
        {
            get { return Fields.PersonFirstname[this]; }
            set { Fields.PersonFirstname[this] = value; }
        }

        [DisplayName("Person Lastname"), Expression("jPerson.[LASTNAME]")]
        public String PersonLastname
        {
            get { return Fields.PersonLastname[this]; }
            set { Fields.PersonLastname[this] = value; }
        }

        [DisplayName("Actor/Actress"),
         Expression("(jPerson.Firstname || ' ' || jPerson.Lastname)")]
        public String PersonFullname
        {
            get { return Fields.PersonFullname[this]; }
            set { Fields.PersonFullname[this] = value; }
        }

        [DisplayName("Person Birthdate"), Expression("jPerson.[BIRTHDATE]")]
        public DateTime? PersonBirthdate
        {
            get { return Fields.PersonBirthdate[this]; }
            set { Fields.PersonBirthdate[this] = value; }
        }

        [DisplayName("Person Birthplace"), Expression("jPerson.[BIRTHPLACE]")]
        public String PersonBirthplace
        {
            get { return Fields.PersonBirthplace[this]; }
            set { Fields.PersonBirthplace[this] = value; }
        }

        [DisplayName("Person Gender"), Expression("jPerson.[GENDER]")]
        public Int32? PersonGender
        {
            get { return Fields.PersonGender[this]; }
            set { Fields.PersonGender[this] = value; }
        }

        [DisplayName("Person Height"), Expression("jPerson.[HEIGHT]")]
        public Int32? PersonHeight
        {
            get { return Fields.PersonHeight[this]; }
            set { Fields.PersonHeight[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.MoviecastId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.MovieCharacter; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MovieCastRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MoviecastId;
            public Int32Field MovieId;
            public Int32Field PersonId;
            public StringField MovieCharacter;

            public StringField MovieTitle;
            public StringField MovieDescription;
            public StringField MovieStoryline;
            public Int32Field MovieReleaseYear;
            public DateTimeField MovieReleaseDate;
            public Int32Field MovieRuntime;
            public Int32Field MovieKind;

            public StringField PersonFirstname;
            public StringField PersonLastname;
            public StringField PersonFullname;
            public DateTimeField PersonBirthdate;
            public StringField PersonBirthplace;
            public Int32Field PersonGender;
            public Int32Field PersonHeight;

            public RowFields()
                : base("MOVIECAST","MovieDB")
            {
                LocalTextPrefix = "MovieDB.MovieCast";
            }
        }
    }
}
