using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
      private readonly ToDoListContext _db;

      public HomeController(ToDoListContext db)
      { 
        _db = db;
      }


      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Category> model = _db.Categories.ToList();
        return View(model);
      }

      [Route("/favorite_photos")]
      public ActionResult FavoritePhotos()
      {
        return View();
      }
    }
}