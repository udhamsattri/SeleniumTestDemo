using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestFramework
{
    public static class Browser
    {
        static IWebDriver webDriver = new ChromeDriver(@"c:\libraries\");

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;           
        }

        public static void Wait(int seconds)
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}