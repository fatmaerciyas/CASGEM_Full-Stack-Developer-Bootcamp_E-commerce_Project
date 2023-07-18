using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IDiscountService _discountService;

        [HttpGet]
        public IActionResult CreateCode()
        {
            string[] symbols = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M" };
            int c1, c2, c3, c4;
            Random random = new Random();
            c1 = random.Next(0, symbols.Length);
            c2 = random.Next(0, symbols.Length);
            c3 = random.Next(0, symbols.Length);
            c4 = random.Next(0, symbols.Length);
            int c5 = random.Next(10, 100);
            ViewBag.v = symbols[c1] + symbols[c2] + symbols[c3] + symbols[c4] + c5;

            return View();
        }

        [HttpPost]
        public IActionResult CreateCode(Discount discount)
        {
            discount.Created_Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            discount.Final_Date = Convert.ToDateTime(DateTime.Now.AddDays(3));
            _discountService.TInsert(discount);
          
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DiscountCodeList()
        {
            var values = _discountService.TGetList();
            return View(values);
        }
    }
}


//Mesajlar 
//Kategoriler
//Ürünler
//İndirim Kodları