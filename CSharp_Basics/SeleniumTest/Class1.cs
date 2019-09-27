using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    [TestFixture]
    public class Class1
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // dodanie nowej instancji ChromeDriver
            driver = new ChromeDriver();
        }

        [Test]
        public void FirstTest()
        {

            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

        }

        // atrybut odpowiadający za 'sprzątanie' - [TearDown]
        [TearDown]
        public void TearDown()
        {
            // zamykanie przeglądarki (obojętnie czy test się wykona czy nie)
            // driver.Close() lub driver.Quit()
            driver.Quit();
        }


    }
}
