using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Promotions.Models;

namespace Promotions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Representative_Page()
        {
            return View();
        }

        public IActionResult Customer_Page()
        {
            return View();
        }

        public IActionResult Promotion_Page()
        {
            var promotion = new PromotionViewModel()
            {
                Name = "Carlos",
                ClaimedAmount = 100
            };
            return View(promotion);
        }

        [HttpPost]
        public IActionResult Assign(StartPromotion promotion)
        {
            if (ModelState.IsValid)
            {
                //var dd = new IAppPromotion();

                return this.Ok();
            }
            return this.BadRequest("Error");
        }

        [HttpPost]
        public IActionResult Search(Customer customer)
        {
            if (ModelState.IsValid)
            {
                return this.Ok();
            }
            return this.BadRequest("Error");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
