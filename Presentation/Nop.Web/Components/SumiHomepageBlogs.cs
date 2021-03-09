using Microsoft.AspNetCore.Mvc;
using Nop.Core.Domain.Blogs;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;

namespace Nop.Web.Components
{
    public class SumiHomepageBlogsViewComponent : NopViewComponent
    {
        private readonly IBlogModelFactory _blogModelFactory;
        private readonly BlogSettings _blogSettings;

        public SumiHomepageBlogsViewComponent(IBlogModelFactory blogModelFactory, BlogSettings blogSettings)
        {
            _blogModelFactory = blogModelFactory;
            _blogSettings = blogSettings;
        }

        public IViewComponentResult Invoke()
        {
            if (!_blogSettings.Enabled)
                return Content("");

            var model = _blogModelFactory.PrepareHomepageBlogItemsModel();
            return View(model);
        }
    }
}
