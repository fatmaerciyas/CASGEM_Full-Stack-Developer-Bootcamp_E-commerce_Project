using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
            public IViewComponentResult Invoke()
            {
                ViewBag.title1 = "Her gün Pizza Yiyin";
                ViewBag.title2 = "Sevdiğiniz pizzaları paylaşın";
                return View();
            }
        
    }
}
