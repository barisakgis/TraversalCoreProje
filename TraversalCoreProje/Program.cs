using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
 
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using DataAccesLayer.Concrete;  // DbContext sýnýfýnýn namespace'ini ekleyin
using EntityLayer.Concrete; // AppUser ve AppRole sýnýflarýnýn namespace'ini ekleyin
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using TraversalCoreProje.Models;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramework;
using Microsoft.Extensions.Logging;
using FluentValidation;
using DTOLayer.DTOs.AnnouncementDTOs;
using BusinessLayer.ValidationRules;
using FluentValidation.AspNetCore;
  
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews().AddFluentValidation(); // ekledik kýzabilir

builder.Services.AddControllersWithViews(config =>
{
	var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
	config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddLogging(x =>
{
    x.ClearProviders();  // mevcutta varsa loglarý temizle demek

    x.SetMinimumLevel(LogLevel.Debug);  // debugtan baþladý  debug f12 ile enum yapýsýna atar bakarsýn
    x.AddDebug();   // output üzerinde göstersin dersek   home controller da var bazý kodlar  

});
 

builder.Services.AddMvc();
// video 29 
builder.Services.AddDbContext<Context>();
 
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>()
    .AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();

builder.Services.AddHttpClient();

// automapper
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();

// 

builder.Services.AddControllersWithViews().AddFluentValidation(); // ekledik kýzabilir

builder.Services.AddScoped<ICommentService, CommentManager>();
builder.Services.AddScoped<ICommentDal, EfCommentDal>();

builder.Services.AddScoped<IDestinationService, DestinationManager>();
builder.Services.AddScoped<IDestinationDal, EfDestinationDal>();

builder.Services.AddScoped<IAppUserService, AppUserManager>();
builder.Services.AddScoped<IAppUserDal, EfAppUserDal>();

builder.Services.AddScoped<IReservationService, ReservationManager>();
builder.Services.AddScoped<IReservationDal, EfReservationDal>();

builder.Services.AddScoped<IGuideService, GuideManager>();
builder.Services.AddScoped<IGuideDal, EfGuideDal>();

builder.Services.AddScoped<IExcelService, ExcelManager>();

builder.Services.AddScoped<IPdfService,PdfManager>();

builder.Services.AddScoped<IContactUsSevice, ContactUsManager>();
builder.Services.AddScoped<IContactUsDal, EfContactUsDal>();

builder.Services.AddScoped<IAnnouncementService, AnnouncementManager>();
builder.Services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();


var app = builder.Build();

 

ILoggerFactory loggerFactory = new LoggerFactory();
var path = Directory.GetCurrentDirectory();
loggerFactory.AddFile($"{path}\\Logs\\log1.txt");  // buraya loglarý yazmasý lazým

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();  /// biz ekledik
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

 


app.Run();
