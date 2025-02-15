﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SeleniumTest.Pages
{
    public class ContactUsPage
    {
        private IWebDriver driver;
        private WebDriverWait waitDriver;
        private By submitButtonLocator = By.CssSelector("#submitMessage");
        private By errorMessageLocator = By.CssSelector(".alert-danger li");

        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
        }

    public void GoToPage()
        {
            string url = ConfigurationManager.AppSettings["url"];
            driver.Navigate().GoToUrl($"{url}/index.php?controller=contact");
            // driver.Navigate().GoToUrl($"{url}");
        }

        public void ClickSubmitbutton()
        {
            driver.FindElement(submitButtonLocator).Click();
        }

    public string GetErrorMessageText()
        {
            var errorMessage = waitDriver.Until(ExpectedConditions.ElementExists(errorMessageLocator));
            return errorMessage.Text;
        }
    public bool IsErrorMessageDisplayed()
        {
            var errorMessage = waitDriver.Until(ExpectedConditions.ElementExists(errorMessageLocator));
            return errorMessage.Displayed;
        }
    }
}
