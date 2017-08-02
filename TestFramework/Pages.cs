using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public static class Pages
    {
        public static MessageListPage ListPage
        {
            get 
            { 
                var listPage = new MessageListPage();
                PageFactory.InitElements(Browser.Driver, listPage);
                return listPage;
            }
        }


        public static AddMessagePage AddMessagePage
        {
            get
            {
                var listPage = new AddMessagePage();
                PageFactory.InitElements(Browser.Driver, listPage);
                return listPage;
            }
        }
    }
}