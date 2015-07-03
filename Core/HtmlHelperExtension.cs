using System.Web;
using System.Web.Mvc;

namespace MvcSmartFlash.Core
{
    public static class HtmlHelperExtension
    {        
        public static IHtmlString RenderFlash(this HtmlHelper html)
        {
            var cssClass = html.ViewContext.TempData["FlashMessage_CssClass"].ToString();
            var message  = html.ViewContext.TempData["FlashMessage_Message"].ToString();
            var flash    = "";

            if(cssClass.HasValue() && message.HasValue())
                flash = string.Format("<div class=\"flash-message {0}\">{1}</div>", cssClass, message);

            return MvcHtmlString.Create(flash);
        }
    }
}
