using Microsoft.AspNetCore.Mvc;
using MusicStore.Web.Models;
using MusicStore.Web.Models.ViewModels;

namespace MusicStore.Web.Controllers;

public class HomeController : Controller
{
    private IStoreRepository _repository;
    
    public HomeController(IStoreRepository repository) => _repository = repository;

    public int PageSize = 4;

    public IActionResult Index(string? category, int productPage = 1) =>
         View(new ProductsListViewModel() { 
            Products = _repository.Products
             .Where(p=> category == null || p.ProductCategory == category)
             .OrderBy(p => p.ProductId)
             .Skip((productPage - 1) * PageSize)
             .Take(PageSize),
         PagingInfo = new PagingInfo() { 
            CurrentPage = productPage,
            ItemsPerPage = PageSize,
            TotalItems = category == null ? _repository.Products.Count()  : _repository.Products.Where(e=>e.ProductCategory== category).Count()
         },
         CurrentCategory= category,
         });
}
