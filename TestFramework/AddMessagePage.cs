using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class AddMessagePage
    {
        [FindsBy(How = How.CssSelector, Using = "body > div > ng-view > div > page-header-widget > div > div")]
        private IWebElement pageMessage;

        public string PageText
        {
            get { return pageMessage.Text; }
        }

        public bool IsAtAddMessagePage()
        {
            var addMsgPage = new AddMessagePage();
            Browser.Wait(8);
            PageFactory.InitElements(Browser.Driver, addMsgPage);
            return addMsgPage.PageText == "Add New Message";
        }



    }
}