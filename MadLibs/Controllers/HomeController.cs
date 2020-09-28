using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Home() { return View(); }

    [Route("/Form")]
    public ActionResult Form() { return View(); }
    [Route("/Form2")]
    public ActionResult Form2() { return View(); }
    [Route("/Form3")]
    public ActionResult Form3() { return View(); }

    [Route("/Story")]
    public ActionResult Story(string holiday, string noun1,
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
    [Route("/Story2")]
    public ActionResult Story2(string Adj1, string Adj2, string Adj3,
    string Adj4, string Adj5, string Adj6, string Noun1, string Noun2, string PrNoun)
    {
      MadLibsVariable2 myMadLibsVariable2 = new MadLibsVariable2();
      myMadLibsVariable2.Adj1 = Adj1;
      myMadLibsVariable2.Adj2 = Adj2;
      myMadLibsVariable2.Adj3 = Adj3;
      myMadLibsVariable2.Adj4 = Adj4;
      myMadLibsVariable2.Adj5 = Adj5;
      myMadLibsVariable2.Noun1 = Noun1;
      myMadLibsVariable2.Noun2 = Noun2;
      myMadLibsVariable2.PrNoun = PrNoun;
      myMadLibsVariable2.Adj6 = Adj6;
      return View(myMadLibsVariable2);
    }
    [Route("/Story3")]
    public ActionResult Story3(string Verb1, string Verb2, string Verb3,
    string Verb4, string Verb5, string Verb6, string Verb7,
    string Adj1, string PrNoun, string Noun1, string Noun2, string Noun3)
    {
      MadLibsVariable3 myMadLibsVariable3 = new MadLibsVariable3();
      myMadLibsVariable3.Noun1 = Noun1;
      myMadLibsVariable3.Noun2 = Noun2;
      myMadLibsVariable3.Noun3 = Noun3;
      myMadLibsVariable3.Adj1 = Adj1;
      myMadLibsVariable3.Verb1 = Verb1;
      myMadLibsVariable3.Verb2 = Verb2;
      myMadLibsVariable3.Verb3 = Verb3;
      myMadLibsVariable3.Verb4 = Verb4;
      myMadLibsVariable3.Verb5 = Verb5;
      myMadLibsVariable3.Verb6 = Verb6;
      myMadLibsVariable3.Verb7 = Verb7;
      myMadLibsVariable3.PrNoun = PrNoun;
      return View(myMadLibsVariable3);
    }

  }
}