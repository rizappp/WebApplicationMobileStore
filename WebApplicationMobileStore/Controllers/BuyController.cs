using Microsoft.AspNetCore.Mvc;
using WebApplication2rrr.Models;

namespace WebApplicationMobileStore.Controllers
{
    public class BuyController : Controller
    {
        MobileContext db;
        public BuyController(MobileContext context)
        {
            db = context;
        }
        public static int globalId;

        [HttpGet]
        public IActionResult GetBuy(int id)
        {
            globalId = id;
            Phone phone = db.Phones.Find(id);
            return View("~/Views/Buy.cshtml", phone);
        }
        [HttpPost]
        public IActionResult PostBuy(string address)
        {
            User user = db.Users.Find(1);
            db.Orders.Add(
                new Order
                {
                    UserId = 1,
                    Address = address,
                    ContactTelephone = user.NumberTelephone,
                    PhoneId = globalId,

                }
            );
            db.SaveChanges();
            return View("~/Views/Thanks.cshtml", user);
        }
    }
}
