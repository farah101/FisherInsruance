using Microsoft.AspNetCore.Mvc;
using System;
namespace FisherInsurance.Models{
public class HomeInsuranceController : Controller
{
    public IActionResult Index()
    {
        //return Ok("This is the index of the HomeInsuranceController");
        return View();
    }

    public IActionResult Quote()
    {
        Quote quote = new Quote 
 { 
            Id = 345, 
            Product = "Home Insurance", 
            ExpireDate = DateTime.Now.AddDays(45), 
            Price = 45.00M 
        };
        //return Ok("This is the qoute of Home/Quote");
        return View(quote);
     }
  }
}