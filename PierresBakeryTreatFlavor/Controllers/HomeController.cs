using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PierresBakeryTreatFlavor.Models;
using System.Collections.Generic;

namespace PierresBakeryTreatFlavor.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresBakeryTreatFlavorContext _db;

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }
  }
}