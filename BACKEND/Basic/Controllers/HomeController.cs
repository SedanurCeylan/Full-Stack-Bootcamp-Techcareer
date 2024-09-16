using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BACKEND.Basic.Models;
using Basic.Models;

namespace Basic.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
            
            return View(Repository.Bootcamps);
    }


}
