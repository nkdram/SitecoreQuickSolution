using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System.Collections.Generic;
using System.Web;

namespace AppName.SCCMS.Extensions
{

    public static class SitecoreHelper
    {

        public static HtmlString DynamicPlaceholder(this Sitecore.Mvc.Helpers.SitecoreHelper helper, string dynamicKey)
        {
            var currentRenderingId = RenderingContext.Current.Rendering.UniqueId;
            return helper.Placeholder(string.Format("{0}_{1}", dynamicKey, currentRenderingId));
        }


        public static IEnumerable<Item> GetMultiListValues(this Item item, ID fieldId)
        {
            return (new MultilistField(item.Fields[fieldId])).GetItems();
        }
    }

}
