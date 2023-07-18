using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.BusinessLayer.ValidationRules.OurTeamValidator;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class OurTeamController : Controller
    {
        public readonly IOurTeamService ourTeamService;

        public OurTeamController(IOurTeamService ourTeamService)
        {
            this.ourTeamService = ourTeamService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddOurTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOurTeam(OurTeam ourTeam)
        {
            CreatOurTeamValidator createOurTeamValidator = new CreatOurTeamValidator();
            ValidationResult result = createOurTeamValidator.Validate(ourTeam);

            if(result.IsValid)
            {
                ourTeamService.TInsert(ourTeam);
                return RedirectToAction("Index");
            }

            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
