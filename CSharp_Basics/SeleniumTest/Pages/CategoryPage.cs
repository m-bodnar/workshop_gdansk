using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Pages
{
    public class CategoryPage
    {
        private IWebDriver driver;
        private By productCounter = By.CssSelector(".heading-counter");
        private By webElements = By.CssSelector("div.product-container");

        public CategoryPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetProductCounter()
        {
            return driver.FindElement(productCounter).Text;
        }


        public string GetActualElementCount()
        {
            int count = 0;
            for(int i = 0; i < 100; i ++)
            {
                int currentCount = driver.FindElements(webElements).Count();
                if(currentCount != count)
                {
                    count = currentCount;
                }
                else
                {
                    break;
                }
            }
            return count.ToString();

            // string actualElementCount = driver.FindElements(webElements).Count.ToString();

        }        
    }
}
