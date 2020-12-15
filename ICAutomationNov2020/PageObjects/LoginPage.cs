using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICAutomationNov2020.PageObjects
{
    public class LoginPage
    {
        // referencing the original driver initialized as Chrome Driver in Test class.
        public void Login(IWebDriver driver)
        {
            driver.FindElement(By.CssSelector("input[name=UserName]")).SendKeys("hari");
            driver.FindElement(By.CssSelector("input[id=Password]")).SendKeys("123123");
            driver.FindElement(By.CssSelector("input[type=submit]")).Click();
        }
    }
}
