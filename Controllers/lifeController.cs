using Microsoft.AspNetCore.Mvc;
using System;
namespace FisherInsurance.Models{
public class lifeController : Controller
{
    public IActionResult Index()
    {
        //return Ok("This is the index of the lifeController");
        return View();
    }

    public IActionResult Quote()
    {
        Quote quote = new Quote 
 { 
            Id = 345, 
            Product = "Life Insurance", 
            ExpireDate = DateTime.Now.AddDays(45), 
            Price = 45.00M 
        };
        //return Ok("This is the qoute of Life/Quote");
        return View(quote);
     }
  }
}