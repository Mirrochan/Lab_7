using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseOfWorkers.Controllers
{
    [Authorize(Roles ="Manager")]
    public class AdditionalInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
