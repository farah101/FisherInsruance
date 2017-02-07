using Microsoft.AspNetCore.Mvc;

public class lifeController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the lifeController");
    }

    public IActionResult Quote()
    {
        return Ok("This is the quote of Life/Auto");
    }
}