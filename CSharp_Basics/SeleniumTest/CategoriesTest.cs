using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Pages;

namespace SeleniumTest
{
    [TestFixture]
    // public class CategoriesTest : TestBase - CategoriesTest dziedziczy z pliku TestBase
    public class CategoriesTest : TestBase
    {
        // sut -system under test
        HomePage sut;
        CategoryPage sut1;

        [SetUp]
        public void HomeSetup()
        {
            sut = new HomePage(driver);
            sut.GoToHomePage();
            sut1 = new CategoryPage(driver);
        }
        

        [Test]
        public void FirstTest()
        {

            sut.ClickCategoryHeader();

            //var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='Dresses']"));  //ten element musimy do czegoś przypisać
            //// .jedna z klas > weź bezpośrednie dziecko
            //categoryHeader.Click();

            var text = sut1.GetProductCounter();
            
            //var productCounter = driver.FindElement(By.CssSelector(".heading-counter"));
            //string text = productCounter.Text;

            sut1.GetActualElementCount();
            //var webElements = driver.FindElements(By.CssSelector("div.product-container")); //mamy kolekcje i możemy z niego brać numery z danej kolekcji

            //string actualElementCount = webElements.Count.ToString();


            // text.Contains("5");  albo lepiej funkcją która obsługuje stringi
            // StringAssert.Contains("5", text);
            StringAssert.Contains(sut1.GetActualElementCount(), text);                      
        }
    }
}
