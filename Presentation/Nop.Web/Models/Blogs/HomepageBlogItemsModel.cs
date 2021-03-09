using Nop.Web.Framework.Models;
using System;
using System.Collections.Generic;

namespace Nop.Web.Models.Blogs
{
    public partial class HomepageBlogItemsModel : BaseNopModel, ICloneable
    {
        public HomepageBlogItemsModel()
        {
            BlogItems = new List<BlogPostModel>();
        }

        public int WorkingLanguageId { get; set; }
        public IList<BlogPostModel> BlogItems { get; set; }

        public object Clone()
        {
            //we use a shallow copy (deep clone is not required here)
            return MemberwiseClone();
        }
    }
}
