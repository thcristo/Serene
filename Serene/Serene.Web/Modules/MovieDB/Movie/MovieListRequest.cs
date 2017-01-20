using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Serenity.Services;

namespace Serene.Modules.MovieDB.Movie
{
    public class MovieListRequest: ListRequest
    {
        public List<int> Genres { get; set; }
    }
}