using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationPractise
{
    [TestClass]
    public class ChromeDriverTest
    {
        private ChromeDriver _driver;

        [TestInitialize]
        public void ChromeDriverInitialize()
        {
            var options = new ChromeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Normal
            };
            _driver = new ChromeDriver("C:/Users/jonat/source/repos/AutomationPractise/AutomationPractise/bin/Debug/netcoreapp2.1");
        }
        //First test is up and running 1/10/19
        [TestMethod]
        public void VerifyPage()
        {
            _driver.Url = "https://ultimateqa.com/automation/";
            _driver.Title.Contains("ultimateqa");
        }

        [TestMethod]
        public void LoginTest()
        {
             
            _driver.Url = "https://ultimateqa.com/automation/";
            var login = WaitForElement(By.CssSelector(".et_pb_text_inner > ul:nth-child(2) > li:nth-child(6) > a:nth-child(1)"));
            login.Click();
            _driver.Title.Equals("https://courses.ultimateqa.com/users/sign_in");
            
            

        }
        [TestCleanup]
        public void ChromeDriverCleanup()
        {
            _driver.Quit();
        }
        public IWebElement WaitForElement(By by, bool mustbeVisible = false, int timeOut = 60)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeOut));
            var element = wait.Until(d => d.FindElement(by));
            //if (mustbeVisible) Look through this later
            //{
            //    wait.Until(ExpectedConditions.ElementIsVisible(by));
            //}
            return element;
        }
    }
    
}
