using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Controllers
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
