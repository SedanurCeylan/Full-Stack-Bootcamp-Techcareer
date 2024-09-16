
using System.Runtime.InteropServices;
using BACKEND.Basic.Models;
using Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace BACKEND.Basic.Controllers{
    public class BootcampController : Controller{
        private string? bootcamp;


        public IActionResult Details(int? id)
        {
            if(id==null){
                return RedirectToAction("Index","Home");
            }
            var Bootcamp = Repository.GetById(id);
 
            return View(bootcamp);
        }

       public IActionResult List()
        {
    
            return View(Repository.Bootcamps);
        }
        
        
    }
}