using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Details(int id)
        {
            //go to database and get the movie information by movie id and send the data(model) to the view
            // use ADO.NET or Dapper to connect with the db.
            // Dapper  stcakoverflow -> Micro ORM
            // Entity FrameWork Core => Full ORM


            // select * from Movies where id = 12;
            // Code is Maintenable, Reusable, Readable, Extensible, testable
            //layers = > layered architecture
            //Onion, clean
            
            return View();
        }
    }
}
