using TechTalk.SpecFlow;
using SpecFlow_Selenium_PO_New.Pages;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//static SpecFlow_Selenium_PO_New.Pages;

namespace SpecFlow_Selenium_PO_Tests.Acceptance_Tests
{
    [Binding]
    public class Test_The_InternetSteps
    {
        private LoginPage login;
        private IWebDriver driver;

        [Given]
        public void Given_I_have_entered_P0_and_P1_into_the_internet(string p0, string p1)
        {
            //ScenarioContext.Current.Pending();
            login = new LoginPage(driver);
        }
        
        [When]
        public void When_I_login()
        {
            //ScenarioContext.Current.Pending();
            login.with("tomsmith", "SuperSecretPassword");
        }
        
        [Then]
        public void Then_I_should_get_a_message_to_say_that_login_was_successful()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
