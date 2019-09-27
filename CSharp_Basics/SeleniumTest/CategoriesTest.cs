using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    [TestFixture]
    // public class CategoriesTest : TestBase - CategoriesTest dziedziczy z pliku TestBase
    public class CategoriesTest : TestBase
    { 
        [Test]
        public void FirstTest()
        {

            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='Dresses']"));  //ten element musimy do czegoś przypisać
            //element.jedna z klas > weź bezpośrednie dziecko
            categoryHeader.Click();
            var productCounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productCounter.Text;
            var webElements = driver.FindElements(By.CssSelector("div.product-container")); //mamy kolekcje i możemy z niego brać numery z danej kolekcji

            string actualElementCount = webElements.Count.ToString();


            // text.Contains("5");  albo lepiej funkcją która obsługuje stringi
            // StringAssert.Contains("5", text);
            StringAssert.Contains(actualElementCount, text);                      
        }
    }
}
