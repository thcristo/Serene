

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "MovieDB/Movie", typeof(Serene.MovieDB.Pages.MovieController))]

namespace Serene.MovieDB.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MovieDB/Movie"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MovieRow))]
    public class MovieController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MovieDB/Movie/MovieIndex.cshtml");
        }
    }
}