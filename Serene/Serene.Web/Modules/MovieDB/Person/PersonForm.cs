
using Serene.MovieDB.Entities;

namespace Serene.MovieDB.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MovieDB.Person")]
    [BasedOnRow(typeof(Entities.PersonRow))]
    public class PersonForm
    {
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public String Birthplace { get; set; }
        public Gender Gender { get; set; }
        public Int32 Height { get; set; }
    }
}