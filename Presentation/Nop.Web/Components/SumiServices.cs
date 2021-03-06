using Microsoft.AspNetCore.Mvc;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;


namespace Nop.Web.Components
{

    public class SumiServicesViewComponent : NopViewComponent
    {
        private readonly ICommonModelFactory _commonModelFactory;

        public SumiServicesViewComponent(ICommonModelFactory commonModelFactory)
        {
            _commonModelFactory = commonModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _commonModelFactory.PrepareFooterModel();
            return View(model);
        }
    }

}
