using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    public string Hello() { return "Hello friend!"; }

    public string Goodbye() { return "Goodbye friend."; }

  }
}