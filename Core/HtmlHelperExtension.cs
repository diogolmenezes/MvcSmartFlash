using System.Web;
using System.Web.Mvc;

namespace MvcSmartFlash.Core
{
    public static class HtmlHelperExtension
    {        
        public static IHtmlString RenderFlash(this HtmlHelper html)
        {
            var cssClass = html.ViewContext.TempData["FlashMessage_CssClass"];
            var message  = html.ViewContext.TempData["FlashMessage_Message"];
            var flash    = "";

            if(cssClass != null && message != null)
                flash = string.Format("<div class=\"flash-message {0}\">{1}</div>", cssClass, message);

            return MvcHtmlString.Create(flash);
        }
    }
}
