using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        SubAboutManager SubAboutManager = new SubAboutManager(new EfSubAboutDal()); 

        public IViewComponentResult Invoke() 
        {
            var values = SubAboutManager.TGetList();
            return View(values); 
        }

    }
}
