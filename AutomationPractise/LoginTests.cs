using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationPractise
{
    [TestClass]
    public class LoginTests : TestCaseBase
    {
        
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
            //I want to move these steps into a base class so the test has a clearer syntax
            var login = WaitForElement(By.CssSelector(".et_pb_text_inner > ul:nth-child(2) > li:nth-child(6) > a:nth-child(1)"));
            login.Click();
            var name = WaitForElement(By.Id("user[email]"));
            name.SendKeys("Test33@test.com");
            var password = WaitForElement(By.Id("user[password]"));
            password.SendKeys("test33");
            var signIn = WaitForElement(By.CssSelector("div.form__button-group > input"));
            signIn.Click();
            _driver.Title.Equals("https://courses.ultimateqa.com/collections"); //This was added for quick verify test



        }
        
        
    }
    
}
