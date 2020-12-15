using ICAutomationNov2020.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace ICAutomationNov2020
{
    public class Tests
    {

        IWebDriver driver;
        LoginPage loginPage = new LoginPage();
        ProfilePage profilePage = new ProfilePage();

        [SetUp]
        public void Setup()
        {
            // Any steps you want to be done before the actual test starts

            driver = new ChromeDriver(); // real browser.
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }


        [Test]
        public void VerifyUserCanLoginIntoHorsePortal()
        {
            //Login Page
            loginPage.Login(driver);

            // Verification on Profile Page
            profilePage.VerifyUserName(driver);

            // Click Admin on Profile Page
            SelectOptionAdmin();


            // Customer Detail Page
            ClickNewCustomerOption();

            CreateNewCustomer();
        }

        private void SelectOptionAdmin()
        {
            driver.FindElements(By.CssSelector("a[data-toggle]"))[0].Click();
        }

        private void ClickNewCustomerOption()
        {
            var customer = driver.FindElement(By.XPath("//a[contains(text(),'Customers')]"));
            customer.Click();
        }

        private void CreateNewCustomer()
        {
            // Create Customer Page
            driver.FindElement(By.CssSelector("p a[class*=btn]")).Click();
            driver.FindElement(By.CssSelector("input[id=Name]")).SendKeys("Hari Om");
            driver.FindElement(By.CssSelector("input[value=Save]")).Click();
        }
    }
}