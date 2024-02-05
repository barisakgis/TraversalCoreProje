//using BusinessLayer.Abstract;
//using BusinessLayer.Concrete;
//using DataAccesLayer.Abstract;
//using DataAccesLayer.EntityFramework;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BusinessLayer.Container
//{
//    public static class Extensions 
//    {
//        public static void ContainerDependencies(this IServiceCollection services)
//        {
//             services.AddScoped<ICommentService, CommentManager>();
//             services.AddScoped<ICommentDal, EfCommentDal>();

//             services.AddScoped<IDestinationService, DestinationManager>();
//             services.AddScoped<IDestinationDal, EfDestinationDal>();

//             services.AddScoped<IAppUserService, AppUserManager>();
//             services.AddScoped<IAppUserDal, EfAppUserDal>();
//        }
//    }
//}
