using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class MessageListPage
    {
        static string Url = "http://localhost:59142/#!/messageList";
        private static string PageTitle = "Angular with TypeScript";

        [FindsBy(How = How.LinkText, Using = "Add Message")]
        private IWebElement pageLink;

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void SelectAddMessage()
        {
            pageLink.Click();            
        }

    }
}