
using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        // public string Hello() { return "Hello friend!"; }
        // public string Goodbye() { return "Goodbye friend."; }

      //   [Route("/hello")]
      //  public string Hello() { return "Hello friend!"; }
       //
      //   [Route("/goodbye")]
      //  public string Goodbye() { return "Goodbye friend."; }
      [Route("/letter")]
        public ActionResult Letter()
        {
          return View();
        }

      [Route("/journal")]
        public ActionResult Journal()
        {
          return View();
        }
      [Route("/")]
      public ActionResult Hello()
       {
         LetterVariable myLetterVariable = new LetterVariable();
         myLetterVariable.SetRecipient("Jessica");
         return View(myLetterVariable);
      }
    }
}
