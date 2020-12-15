using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICAutomationNov2020.PageObjects
{
    public class ProfilePage
    {
        public void VerifyUserName(IWebDriver driver)
        {
            var username = driver.FindElements(By.CssSelector("a[data-toggle=dropdown]"))[1].Text;
            Assert.AreEqual(username, "Hello hari!");
        }
    }
}
