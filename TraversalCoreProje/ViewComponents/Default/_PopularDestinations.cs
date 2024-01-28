using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {

        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal()); 
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();  
             return View(values);
        }

    }
}
