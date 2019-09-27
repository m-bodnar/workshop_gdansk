using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class TestBase
    {
        // private, protected, public
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();  // tworzy obiekt tego drivera, postaw server tego drivera, skoro we wszystkich testach będziemy używać tego driver to inicjalizujemy go poza testem
            var waitTime = new System.TimeSpan(0, 0, 1);
            driver.Manage().Timeouts().ImplicitWait = waitTime;
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
