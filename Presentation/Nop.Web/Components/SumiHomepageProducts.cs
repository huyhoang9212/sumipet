using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Nop.Services.Catalog;
using Nop.Services.Security;
using Nop.Services.Stores;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;
using Nop.Web.Models.Catalog;
using System.Collections.Generic;

namespace Nop.Web.Components
{
    public class SumiHomepageProductsViewComponent : NopViewComponent
    {
        private readonly IAclService _aclService;
        private readonly IProductModelFactory _productModelFactory;
        private readonly IProductService _productService;
        private readonly IStoreMappingService _storeMappingService;
        private readonly ICatalogModelFactory _catalogModelFactory;
        private readonly ICategoryService _categoryService;
        public SumiHomepageProductsViewComponent(IAclService aclService,
            IProductModelFactory productModelFactory,
            IProductService productService,
            IStoreMappingService storeMappingService,
            ICatalogModelFactory catalogModelFactory,
            ICategoryService categoryService)
        {
            _aclService = aclService;
            _productModelFactory = productModelFactory;
            _productService = productService;
            _storeMappingService = storeMappingService;
            _catalogModelFactory = catalogModelFactory;
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke(int? productThumbPictureSize)
        {
            var viewmodel = new List<SumiHomePageProductViewModel>();


            var categories = _catalogModelFactory.PrepareHomepageCategoryModels();

            foreach (var item in categories)
            {
                //var c = new Core.Domain.Catalog.Category();
                var categoryViewModel = new SumiHomePageProductViewModel();

                var category = _categoryService.GetCategoryById(item.Id);
                category.PageSizeOptions = int.MaxValue.ToString();
                category.PageSize = int.MaxValue;

                var command = new Models.Catalog.CatalogPagingFilteringModel
                {
                    PageSize = int.MaxValue,
                    AllowCustomersToSelectPageSize = true,
                    PageNumber = 1
                };

                var categoryProducts = _catalogModelFactory.PrepareCategoryModel(category, command);
                var products = categoryProducts.Products.Where(x => x.ShowOnHomepage);

                categoryViewModel.Category = item;
                categoryViewModel.Products = products.OrderBy(x => x.DisplayOrder).ToList();


                viewmodel.Add(categoryViewModel);
            }


            //var products = _productService.GetAllProductsDisplayedOnHomepage();

            ////ACL and store mapping
            //products = products.Where(p => _aclService.Authorize(p) && _storeMappingService.Authorize(p)).ToList();
            ////availability dates
            //products = products.Where(p => _productService.ProductIsAvailable(p)).ToList();

            //products = products.Where(p => p.VisibleIndividually).ToList();

            //if (!products.Any())
            //    return Content("");

            //var model = _productModelFactory.PrepareProductOverviewModels(products, true, true, productThumbPictureSize).ToList();

            //model.ToList().FirstOrDefault(x => x.ProductType.)

            return View(viewmodel);
        }
    }
}