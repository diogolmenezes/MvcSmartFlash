using System.Web.Mvc;

namespace MvcSmartFlash.Core
{
    public static class FlashMessage
    {
        public static void Flash(this Controller controller, string cssClass, string message)
        {
            controller.TempData["FlashMessage_CssClass"] = cssClass;
            controller.TempData["FlashMessage_Message"]  = message;
        }

        public static void FlashInfo(this Controller controller, string message)
        {
            Flash(controller, "info", message);
        }

        public static void FlashAlert(this Controller controller, string message)
        {
            Flash(controller, "alert", message);
        }

        public static void FlashError(this Controller controller, string message)
        {
            Flash(controller, "error", message);
        }

        public static void FlashSuccess(this Controller controller, string message)
        {
            Flash(controller, "success", message);
        }
    }
}
