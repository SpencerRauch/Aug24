using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetParty.Models;

namespace PetParty.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private static List<Pet> FakePetDb = new();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        List<SelectListItem> Options =
        [
            new(" --- please choose --- ","",true,true),
            new("Bear","Bear"),
            new("Bobcat","Bobcat"),
            new("Raccoon","Raccoon")
        ];
        ViewBag.Options = Options;
        return View("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet("VMFun")]
    public ViewResult VMFun()
    {
        // int Num = 9;
        List<string> Names = ["Bob","Alice","Alex"];
        return View(Names);
    }

    [HttpPost("process")]
    public IActionResult Process(Pet newPet)
    {
        if (!ModelState.IsValid)
        {
            var message = string.Join(" | ", ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage));
            Console.WriteLine(message);
        }
        if (!ModelState.IsValid)
        {
            
            // return View("Index");
            return Index();
        }
        Console.WriteLine($"{newPet.Name} is a {newPet.Age} years old {newPet.Species}");
        Console.WriteLine($"The pet {(newPet.Fun ? "is" : "isn't")} fun");
        FakePetDb.Add(newPet);
        // FakePetDb.SaveChanges(); <--- this is the only other line we'd need if this was a real db!
        return RedirectToAction("AllPets");
        
    }

    [HttpGet("allpets")]
    public ViewResult AllPets()
    {
        return View(FakePetDb);
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
