using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractise
{
    public class TestCaseBase
    {
        public ChromeDriver _driver;

        [TestInitialize]
        public void ChromeDriverInitialize()
        {
            var options = new ChromeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Normal
            };
            _driver = new ChromeDriver("C:/Users/jonat/source/repos/AutomationPractise/AutomationPractise/bin/Debug/netcoreapp2.1");
        }
        public IWebElement WaitForElement(By by, bool mustbeVisible = false, int timeOut = 10)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeOut));
            var element = wait.Until(d => d.FindElement(by));
            //if (mustbeVisible) Look through this later
            //{
            //    wait.Until(ExpectedConditions.ElementIsVisible(by));
            //}
            return element;
        }
        [TestCleanup]
        public void ChromeDriverCleanup()
        {
            _driver.Quit();
        }
    }
}
