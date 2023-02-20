using Microsoft.AspNetCore.Mvc;
using MusicStore.Web.Models;

namespace MusicStore.Web.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRepository _repository;
        
        public NavigationMenuViewComponent(IStoreRepository repository) => _repository = repository;

        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(_repository.Products
            .Select(x => x.ProductCategory)
            .Distinct()
            .OrderBy(x => x));
        }
    }

}
