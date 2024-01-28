using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestiMonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
           return View(values);   
        
        }

    }
}
