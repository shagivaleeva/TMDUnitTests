using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace vk
{
    [TestClass]
    public class ScrollNews
    {
        public static void Scroll(IWebDriver driver, string baseURL)
        {
            driver.FindElement(By.CssSelector("#l_nwsf")).Click();
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string title = (string)js.ExecuteScript("window.scrollTo(0, document.body.clientHeight)");
        }
    }
}
