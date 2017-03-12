using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using police.Models.ViewModels;
using police.Models.Repositories;

namespace police.Controllers
{
    public class HomeController : Controller
    {
        [Route("api/[controllers]")]
        public IActionResult Index()
        {
            return View(new IndexPageViewModel());
        }
        [Route("crimeNames/month")]
        public IActionResult Get() {
          return new ObjectResult(RecordsRepository.getCrimesByMonth()); // objectResult converts the generic to an ienumerable
        }
    }
}
