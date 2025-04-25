using HellAndBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace HellAndBack.Controllers
{
    public class HellAndBackController : Controller
    {
        public IActionResult Index()
        {
            var cards = new List<Card>();
            Card card = new Card();
            card.CardId = 1;
            card.Value = "K";
            card.Suit = "♣";
            cards.Add(card);
            ViewData["cards"] = cards;
            return View();
        }
    }
}
