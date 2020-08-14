using Microsoft.AspNetCore.Mvc;
using PierresBakeryTreatFlavor.Models;
using System.Collections.Generic;

namespace PierresBakeryTreatFlavor.Controllers
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