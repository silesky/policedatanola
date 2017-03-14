using police.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace police.Controllers
{
  public class RecordsController : Controller
  {
    [Route("api/[controller]/month")]

    [HttpGet("")]
    public IActionResult GetAllByMonth()
    {
      return new ObjectResult(RecordsRepository.getCrimesByMonth()); // objectResult converts the generic to an ienumerable
    }
  }
}
