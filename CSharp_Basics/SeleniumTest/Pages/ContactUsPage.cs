﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Pages
{
    public class ContactUsPage
    {
        private IWebDriver driver;
        private By submitButtonLocator = By.CssSelector("#submitMessage");
        private By errorMessageLocator = By.CssSelector(".alert-danger li");

        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

    public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
            // driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

    public void ClickSubmitbutton()
        {
            driver.FindElement(submitButtonLocator).Click();
        }

    public string GetErrorMessage()
        {
            WebDriverWait waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
            var errorMessage = waitDriver.Until(ExpectedConditions.ElementExists(errorMessageLocator));
            return errorMessage.Text;
        }
    }
}
