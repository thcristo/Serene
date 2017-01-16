
namespace Serene.MovieDB.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MovieId { get; set; }
        [EditLink]
        public String Title { get; set; }
        public String Description { get; set; }
        public String Storyline { get; set; }
        public Int32 ReleaseYear { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Width(200), GenreListFormatter]
        public List<Int32> GenreList { get; set; }
        [DisplayName("Runtime in minutes"), Width(150), AlignRight]
        public Int32 Runtime { get; set; }
    }
}