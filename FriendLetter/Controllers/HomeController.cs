using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {

        [Route("/hello")]
        public string Hello() { return "Hello Friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

        [Route("/")]
        public ActionResult Form() { return View(); }

        [Route("/postcard")]
        public ActionResult Postcard(string recipient, string sender, string location, string souvenirs)
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = recipient;
            myLetterVariable.Sender = sender;
            myLetterVariable.Location = location;
            myLetterVariable.Souvenirs = souvenirs;
            return View(myLetterVariable);
        }

    }
}