using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/Story")]
    public ActionResult Madlibs(string holiday, string noun1,
    string place1, string person1, string adj1, string bodypart,
    string verb1, string adj2, string noun2, string food,
    string plNoun, string famPers, string noun3, string food2,
    string food3, string number, string verb2, string familyMem,
     string food4, string bodypart2)
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.holiday = holiday;
      myMadLibsVariable.noun1 = noun1;
      myMadLibsVariable.place1 = place1;
      myMadLibsVariable.person1 = person1;
      myMadLibsVariable.adj1 = adj1;
      myMadLibsVariable.bodypart = bodypart;
      myMadLibsVariable.verb1 = verb1;
      myMadLibsVariable.adj2 = adj2;
      myMadLibsVariable.noun2 = noun2;
      myMadLibsVariable.food = food;
      myMadLibsVariable.plNoun = plNoun;
      myMadLibsVariable.famPers = famPers;
      myMadLibsVariable.noun3 = noun3;
      myMadLibsVariable.food2 = food2;
      myMadLibsVariable.food3 = food3;
      myMadLibsVariable.number = number;
      myMadLibsVariable.verb2 = verb2;
      myMadLibsVariable.familyMem = familyMem;
      myMadLibsVariable.food4 = food4;
      myMadLibsVariable.bodypart2 = bodypart2;

      return View(myMadLibsVariable);
    }

  }
}