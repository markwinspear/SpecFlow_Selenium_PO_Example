using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;

namespace SpecFlow_Selenium_PO_New.Pages
{
    public class BasePage 
    {
        protected IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            driver = new FirefoxDriver();

        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            driver.Quit();
        }
        public IWebElement find(By locator)
        {
            return driver.FindElement(locator);
        }

        public void click(By locator)
        {
            find(locator).Click();
        }

        public void submit(By locator)
        {
            find(locator).Submit();
        }

        public void clear(By locator)
        {
            find(locator).Clear();
        }

        public void type(String inputText, By locator)
        {
            find(locator).SendKeys(inputText);
        }

        public Boolean isDisplayed(By locator)
        {
            try
            {
                IWebElement element = find(locator);
                return element.Displayed && element.Enabled;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }
    }
}
