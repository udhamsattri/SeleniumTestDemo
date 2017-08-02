using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace SeleniumTests
{
    [TestClass]
    public class MessageListPageTests
    {
        [TestMethod]
        public void Can_Go_To_HomePage()
        {
            Pages.ListPage.Goto();
            Assert.IsTrue(Pages.ListPage.IsAt());
        }

        [TestMethod]
        public void Can_Go_To_Author_Page()
        {
            Pages.ListPage.Goto();
            Pages.ListPage.SelectAddMessage();
            Assert.IsTrue(Pages.AddMessagePage.IsAtAddMessagePage());
        }

        [TestCleanup]
        public void CleanUp()
        {
            //Browser.Close();
        }
    }

}
