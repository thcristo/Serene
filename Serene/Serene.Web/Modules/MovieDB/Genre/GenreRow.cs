
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

    [ConnectionKey("Default"), DisplayName("Genres"), InstanceName("Genre"), TwoLevelCached]
    [ReadPermission(MovieDBPermissionKeys.Administration)]
    [ModifyPermission(MovieDBPermissionKeys.Administration)]
    [LookupScript("MovieDB.Genre")]
    public sealed class GenreRow : Row, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Genre Id"), Column("GENRE_ID"), Identity]
        public Int32? GenreId
        {
            get { return Fields.GenreId[this]; }
            set { Fields.GenreId[this] = value; }
        }

        [DisplayName("Name"), Column("NAME"), Size(100), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [Column("TENANT_ID"), Insertable(false), Updatable(false)]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.GenreId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public Int32Field TenantIdField
        {
            get
            {
                return Fields.TenantId;
            }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public GenreRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field GenreId;
            public StringField Name;
            public Int32Field TenantId;

            public RowFields()
                : base("GENRE","MovieDB")
            {
                LocalTextPrefix = "MovieDB.Genre";
            }
        }
    }
}
