using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        private By categoryHeader = By.CssSelector("ul.sf-menu > li > a[title='Dresses']");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        public void ClickCategoryHeader()
        {
            driver.FindElement(categoryHeader).Click();
        }
    }
}
