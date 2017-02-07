using Microsoft.AspNetCore.Mvc;

public class AutoController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the  Auto");
    }

    public IActionResult Quote()
    {
        return Ok("This is the quote of the Auto/Quote");
    }


}