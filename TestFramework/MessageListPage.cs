using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class MessageListPage
    {
        static string Url = "http://localhost:59142/#!/messageList";
        private static string PageTitle = "Angular with TypeScript";
        private static string MsgListLabel = "Message List";

        [FindsBy(How = How.LinkText, Using = "Add Message")]
        private IWebElement pageLink;

        [FindsBy(How = How.CssSelector, Using = "body > div > ng-view > div > div.panel-heading.ng-binding")]
        private IWebElement msgListLabel;

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

        public bool IsMessageListLabelOnPage()
        {
            Browser.Wait(8);
            return msgListLabel.Text == MsgListLabel;
        }
    }
}