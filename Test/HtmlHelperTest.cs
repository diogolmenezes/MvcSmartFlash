using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcSmartFlash.Core;
using MvcSmartFlash.Test.Util;
using System.IO;
using System.Web.Mvc;


namespace MvcSmartFlash.Test
{
    [TestClass]
    public class HtmlHelperTest
    {
        [TestMethod]
        public void Render_Flash_Must_Show_Flash()
        {
            var testController = new TestController();
            
            // define flash
            testController.Flash("test", "message");
            
            // render flash
            var html = GetHtmlHelper(testController).RenderFlash().ToHtmlString();

            Assert.AreEqual(html, "<div class=\"flash-message test\">message</div>");
        }

        [TestMethod]
        public void Render_Flash_Must_Show_Success_Flash()
        {
            var testController = new TestController();

            // define flash
            testController.FlashSuccess("success message");

            // render flash
            var html = GetHtmlHelper(testController).RenderFlash().ToHtmlString();

            Assert.AreEqual(html, "<div class=\"flash-message success\">success message</div>");
        }

        [TestMethod]
        public void Render_Flash_Must_Show_Error_Flash()
        {
            var testController = new TestController();

            // define flash
            testController.FlashError("error message");

            // render flash
            var html = GetHtmlHelper(testController).RenderFlash().ToHtmlString();

            Assert.AreEqual(html, "<div class=\"flash-message error\">error message</div>");
        }

        [TestMethod]
        public void Render_Flash_Must_Show_Info_Flash()
        {
            var testController = new TestController();

            // define flash
            testController.FlashInfo("info message");

            // render flash
            var html = GetHtmlHelper(testController).RenderFlash().ToHtmlString();

            Assert.AreEqual(html, "<div class=\"flash-message info\">info message</div>");
        }

        [TestMethod]
        public void Render_Flash_Must_Show_Alert_Flash()
        {
            var testController = new TestController();

            // define flash
            testController.FlashAlert("alert message");

            // render flash
            var html = GetHtmlHelper(testController).RenderFlash().ToHtmlString();

            Assert.AreEqual(html, "<div class=\"flash-message alert\">alert message</div>");
        }

        private  HtmlHelper GetHtmlHelper(Controller controller)
        {
            return new HtmlHelper(new ViewContext(controller.ControllerContext, new WebFormView(controller.ControllerContext, "view"), controller.ViewData, controller.TempData, TextWriter.Null), new ViewPage());
        }
    }
}
