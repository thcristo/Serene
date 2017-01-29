
namespace Serene.Administration.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Default"), DisplayName("Languages"), InstanceName("Language"), TwoLevelCached]
    [ReadPermission(PermissionKeys.Translation)]
    [ModifyPermission(PermissionKeys.Translation)]
    public sealed class LanguageRow : Row, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Language Id"), Size(10), NotNull, QuickSearch]
        public String LanguageId
        {
            get { return Fields.LanguageId[this]; }
            set { Fields.LanguageId[this] = value; }
        }

        [DisplayName("Language Name"), Size(50), NotNull, QuickSearch]
        public String LanguageName
        {
            get { return Fields.LanguageName[this]; }
            set { Fields.LanguageName[this] = value; }
        }

        [Column("TENANT_ID"), Insertable(false), Updatable(false)]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.LanguageName; }
        }

        public Int32Field TenantIdField
        {
            get
            {
                return Fields.TenantId;
            }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public LanguageRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField LanguageId;
            public StringField LanguageName;
            public Int32Field TenantId;
            public RowFields()
                : base("Languages", "Administration")
            {
                LocalTextPrefix = "Administration.Language";
            }
        }
    }
}