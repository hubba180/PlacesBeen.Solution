using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;

namespace PlacesBeen.Controllers
{
  public class HomeController : Controller
  {    
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}