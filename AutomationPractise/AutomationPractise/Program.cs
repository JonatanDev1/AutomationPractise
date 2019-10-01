using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
        [TestCleanup]
        public void ChromeDriverCleanup()
        {
            _driver.Quit();
        }
    }
    
}
