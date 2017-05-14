using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;

namespace vk
{
    [TestClass]
    public class LoginTest
    {
        public static void Login(IWebDriver driver, string baseURL)
        {
            driver.FindElement(By.Id("index_email")).Click();
            driver.FindElement(By.Id("index_email")).SendKeys(Constants.userLogin);
            driver.FindElement(By.Id("index_pass")).Click();
            driver.FindElement(By.Id("index_pass")).SendKeys(Constants.userPassword);
            driver.FindElement(By.Id("index_login_button")).Click();
        }

        public static void WaitTwoStepAuthentificaion(IWebDriver driver, string selector)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(selector)));
        }
    }
}
