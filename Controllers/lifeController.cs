using Microsoft.AspNetCore.Mvc;

public class lifeController : Controller
{
    public IActionResult Index()
    {
        //return Ok("This is the index of the lifeController");
        return View();
    }

    public IActionResult Quote()
    {
        return View();
        //return Ok("This is the quote of Life/Auto");
    }
}