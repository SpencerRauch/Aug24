using Microsoft.AspNetCore.Mvc;

// [Route("pizza")]
public class FirstController : Controller
{
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "Hello from our Controller!";
    }

    [HttpGet("two")]
    public string PageTwo()
    {
        return "<h1>A Second page has been created!</h1>";
    }

    // [HttpGet("params/{id}/{name}")]
    // public string Params(int id, string name)
    // {
    //     return $"{name} supplied id: {id}";
    // }

    [HttpGet("params/{id}/{name}")]
    public ViewResult Params(int id, string name)
    {
        ViewBag.id = id;
        ViewBag.name = name;
        return View();
    }

    [HttpGet("view")]
    public ViewResult FirstView()
    {
        return View("TestView");
    }

    [HttpGet("form")]
    public ViewResult FirstForm()
    {
        return View();
    }

    // [HttpPost("process")]
    // public RedirectResult Process(int id, string name)
    // {
    //     Console.WriteLine($"{name} supplied id: {id}");
    //     return Redirect($"params/{id}/{name}");
    // }

    // [HttpPost("process")]
    // public RedirectToActionResult Process(int id, string name)
    // {
    //     Console.WriteLine($"{name} supplied id: {id}");
    //     return RedirectToAction("Params", new {id,name=name});
    // }
    [HttpPost("process")]
    public IActionResult Process(int id, string name)
    {
        Console.WriteLine($"{name} supplied id: {id}");
        if (id == 123)
        {
            return View("SecretPage");
        }
        return RedirectToAction("Params", new {id,name=name});
    }


    [HttpGet("{**path}")]
    public string Lost()
    {
        return "You are lost";
    }

}