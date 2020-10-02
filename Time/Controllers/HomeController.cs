using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")]       //type of request
           //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View("Index");
        }
    }
}
