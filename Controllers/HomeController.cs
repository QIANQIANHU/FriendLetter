
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
         myLetterVariable.SetRecipient("Qianqian");
         myLetterVariable.SetSender("Faiza");
         return View(myLetterVariable);
      }

      [Route("/form")]
      public ActionResult Form()
      {
        return View();
      }

      [Route("/greeting_card")]
        public ActionResult GreetingCard()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient(Request.Query["recipient"]);
            myLetterVariable.SetSender(Request.Query["sender"]);
            return View("Hello", myLetterVariable);
        }
        
      [Produces("text/html")]
      [Route("/favorite_photos")]
      public ActionResult FavoritePhotos()
      {
        return View();
      }

    }
}
