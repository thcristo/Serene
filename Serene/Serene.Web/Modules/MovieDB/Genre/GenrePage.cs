

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "MovieDB/Genre", typeof(Serene.MovieDB.Pages.GenreController))]

namespace Serene.MovieDB.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MovieDB/Genre"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.GenreRow))]
    public class GenreController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MovieDB/Genre/GenreIndex.cshtml");
        }
    }
}