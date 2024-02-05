using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {

        private readonly IDestinationService _destinationService;  // depence injection yapıyoruz _ ile de this gelmesin diyoruz

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);      // index üzerinde listele butonuna tıkladığımızda sayfa refresh olmadan  citylist gelecek
        }


        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
             destination.Status = true;
            destination.Image = "";
            destination.Description = "";
            destination.CoverImage = "";
            destination.Details1 = "";
            destination.Details2 = "";
            destination.Image2 = "";

            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);

        }
        public IActionResult GetById(int DestinationID)
        {
            var values = _destinationService.tGetByID(DestinationID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.tGetByID(id);
            _destinationService.TDelete(values);
            return NoContent();
        }

        public IActionResult UpdateCity(Destination destination)
        {
            _destinationService.TUpdate(destination);
            var v = JsonConvert.SerializeObject(destination);
            return Json(v);
        }




         


        // Static veri için  //public static List<CityClass> cities = new List<CityClass>
        //{

        //    new CityClass
        //    {
        //        CityID = 1,
        //         CityName = "Sinop",
        //          CityCountry = "Türkiye"
        //    },
        //    new CityClass
        //    {
        //        CityID = 2,
        //         CityName = "üsküp",
        //          CityCountry = "Makedonya"
        //    },
        //    new CityClass
        //    {
        //        CityID = 3,
        //         CityName = "Roma",
        //          CityCountry = "İtalya"
        //    }


        //};  ///  /


    }
}
