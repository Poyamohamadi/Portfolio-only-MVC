using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using asp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace asp.Controllers;

public class HomeController : Controller
{
    // private readonly List<Services>  _services = new List<Services>
    // {
    //     new Services(1, "Photography"),
    //     new Services(2, "Travel"),
    //     new Services(3, "Fashion"),
    //     new Services(4, "Video"),
    //     new Services(5, "Audio"),
    // };
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Photography()
    {
        return View();
    }


    public IActionResult About()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Contact()
    {
        var model = new Contact();
        // {
        //     Services = new SelectList(_services, "Id", "Name")
        // };
        return View(model);
    }
    
    [HttpPost]
    public IActionResult Contact(Contact model)
    {
        // model.Services = new SelectList(_services, "Id", "Name");
        if (!ModelState.IsValid)
        {
            ViewBag.Success = false;
            return View(model);
        }

        
        ViewBag.Success = true;
        ModelState.Clear();
        return View();
        
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
