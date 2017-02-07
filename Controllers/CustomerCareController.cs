using Microsoft.AspNetCore.Mvc;

[RouteAttribute("claim")]
public class CustomerCareController : Controller
{

    [RouteAttribute("fileclaim")]
    public IActionResult NewClaim()
    {
        return Ok("New Claim of CustomerCareController");
    }

    [RouteAttribute("claimstatus")]
    public IActionResult ClaimHistory()
    {
        return Ok("This is the customer claims hiatory");
    }
}