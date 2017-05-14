using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace vk
{
    [TestClass]
    public class UnitTest1
    {
        private static IWebDriver driver;
        private static string baseURL;

        [ClassInitialize]
        public static void Main(TestContext context)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            baseURL = Constants.baseUrl;
            driver.Navigate().GoToUrl(baseURL);
        }

        [TestMethod]
        public void Common()
        {
            LoginTest.Login(driver, baseURL);
            Thread.Sleep(2000);
            LoginTest.WaitTwoStepAuthentificaion(driver, "#l_nwsf");
            Thread.Sleep(5000);
            Post.PostInNews(driver, baseURL);
            Thread.Sleep(2000);
            Post.PostInMain(driver, baseURL);
            ScrollNews.Scroll(driver, baseURL);
        }

    }
}
