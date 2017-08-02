using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace SeleniumTests
{
    [TestClass]
    public class MessageListPageTests
    {
        [TestMethod]
        public void Can_Go_To_MessageList_Page()
        {
            Pages.ListPage.Goto();
            Assert.IsTrue(Pages.ListPage.IsAt());
        }

        [TestMethod]
        public void Can_Go_To_AddMessage_Page()
        {
            Pages.ListPage.Goto();
            Pages.ListPage.SelectAddMessage();
            Assert.IsTrue(Pages.AddMessagePage.IsAtAddMessagePage());
        }


        [TestMethod]
        public void Verify_Message_List_Label_On_MessageList_Page()
        {
            Pages.ListPage.Goto();
            Assert.IsTrue(Pages.ListPage.IsMessageListLabelOnPage());
        }


        [TestCleanup]
        public void CleanUp()
        {
            //Browser.Close();
        }
    }

}
