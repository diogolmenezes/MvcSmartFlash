using System.Web.Mvc;

namespace MvcSmartFlash.Test.Util
{    public class TestController : Controller
    {
        public TestController()
        {
            this.ControllerContext = new ControllerContext();
        }
    }
}
