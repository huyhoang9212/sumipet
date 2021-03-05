using Microsoft.AspNetCore.Mvc;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;


namespace Nop.Web.Components
{

    public class SumiSlidersViewComponent : NopViewComponent
    {
        private readonly ICommonModelFactory _commonModelFactory;

        public SumiSlidersViewComponent(ICommonModelFactory commonModelFactory)
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
