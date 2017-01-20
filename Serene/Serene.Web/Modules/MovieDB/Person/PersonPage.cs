



namespace Serene.MovieDB.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MovieDB/Person"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PersonRow))]
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MovieDB/Person/PersonIndex.cshtml");
        }
    }
}