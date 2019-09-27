using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumTest.Pages;

namespace SeleniumTest
{
    [TestFixture]
    public class ContactUsTest : TestBase
    {
        // sut -system under test
        ContactUsPage sut;

        [SetUp]
        public void ContactUsSetup()
        {
            sut = new ContactUsPage(driver);
            sut.GoToPage();
        }

        [Test]
        public void SendButtonTest()
        {
            sut.ClickSubmitbutton();
            // var button = driver.FindElement(By.CssSelector("#submitMessage"));
            // button.Click();

            var errorMessage = sut.GetErrorMessage();
            // WebDriverWait waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
            // var errorMessage = waitDriver.Until(ExpectedConditions.ElementExists(By.CssSelector(".alert-danger li")));

            // var errorMessage = driver.FindElement(By.CssSelector(".alert-danger li"));

            Assert.That(errorMessage, Contains.Substring("Invalid email address."));
        }
    }
}
