using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_Selenium_PO_New.Pages
{
    public class LoginPage : BasePage
    {
        //IWebDriver driver;
        string pageTitle = "The Internet";
        By open = By.Id("open");
        By usernameField = By.Id("username");
        By passwordField = By.Id("password");
        By loginButton = By.Id("login-button");
        By successMessageLocator = By.CssSelector(".flash.success");
        By failureMessageLocator = By.CssSelector(".flash.error");

        public LoginPage(IWebDriver driver) : base(driver)
        {
            
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/login");
            string actualTitle = driver.Title;
            if (!actualTitle.Equals(pageTitle))
            {
                throw new InvalidOperationException("This is not the " + pageTitle + " page. The title of this page is " + actualTitle);
            }
        }

        public void with(String username, String password)
        {
            type(username, usernameField);
            type(password, passwordField);
            submit(loginButton);
        }

        public Boolean success()
        {
            return isDisplayed(successMessageLocator);
        }

        public Boolean failure()
        {
            return isDisplayed(failureMessageLocator);
        }
    }
}
