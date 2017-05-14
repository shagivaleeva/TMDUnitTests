using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace vk
{
    [TestClass]
    public class Post
    {
        public static void PostInNews(IWebDriver driver, string baseURL)
        {
            driver.FindElement(By.Id("post_field")).Click();
            driver.FindElement(By.Id("post_field")).SendKeys("Всем привет с Новостей");
            driver.FindElement(By.Id("send_post")).Click();
        }

        public static void PostInMain(IWebDriver driver, string baseURL)
        {
            driver.FindElement(By.CssSelector("#l_pr a")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("post_field")).Click();
            driver.FindElement(By.Id("post_field")).SendKeys("Всем привет с Главной страницы!");
            driver.FindElement(By.Id("send_post")).Click();
        }

    }
}
