using Microsoft.EntityFrameworkCore;
using MusicStore.Web.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<StoreDbContext>(options
    => { options.UseSqlServer(builder.Configuration["ConnectionStrings:MusicStoreConnection"]); });
builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();
builder.Services.AddRazorPages();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();


var app = builder.Build();
app.UseStaticFiles();
app.UseSession();
app.MapControllerRoute("catpage", 
    "{category}/Page{productPage:int}", 
    new { Controller = "Home", action = "Index" });
app.MapControllerRoute("page", 
    "Page{productPage:int}", 
    new { Controller = "Home", action = "Index", productPage = 1});
app.MapControllerRoute("category", 
    "{category}", 
    new { Controller = "Home", action = "Index", productPage = 1});
app.MapControllerRoute("pagination", 
    "Products/Page{productPage}", 
    new { Controller = "Home", action = "Index", productPage = 1 });
app.MapDefaultControllerRoute();
app.MapRazorPages();

SeedData.EnsurePopulated(app);

app.Run();
