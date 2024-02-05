using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsSevice _contactUsSevice;

        public ContactUsController(IContactUsSevice contactUsSevice)
        {
            _contactUsSevice = contactUsSevice;
        }

        public IActionResult Index()
        { 
            var values = _contactUsSevice.TGetListContactUsByTrue();
            return View(values);
        }
    }
}
