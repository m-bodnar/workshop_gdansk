using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest
{
    [TestFixture]
    public class ContactUsTest : TestBase
    {
        [SetUp] // dodać, jeżeli wykonuje się więcej testów na tej samej stronie
        public void ContactUsSetup()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
        }

        [Test]
        public void SendButtonTest()
        {           
            var button = driver.FindElement(By.CssSelector("#submitMessage"));
            button.Click();

            WebDriverWait waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
            var errorMessage = waitDriver.Until(ExpectedConditions.ElementExists(By.CssSelector(".alert-danger li")));

            // var errorMessage = driver.FindElement(By.CssSelector(".alert-danger li"));

            Assert.IsTrue(errorMessage.Displayed, "Error message was not displayed");
            Assert.AreEqual("Invalid email address.", errorMessage.Text);

            // Assert.AreEqual("Invalid email address.", errorMessage.Text); można zapisac jako: 
            // Assert.That(errorMessage.Text, Is.EqualTo("Invalid email address.")); 
            // czytelniejsza wersja
        }
    }
}
