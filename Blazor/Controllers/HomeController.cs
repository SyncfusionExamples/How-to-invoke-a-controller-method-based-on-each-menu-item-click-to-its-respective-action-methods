using Microsoft.AspNetCore.Mvc;

namespace MenuBarSample.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
       public void Save()
        {
          Console.WriteLine("save is clicked");
        }
    }
}
