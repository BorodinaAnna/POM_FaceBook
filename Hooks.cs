using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MyAccount
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public static void BeforeTestRun()
        {
            IWebDriver driver;

            driver = new ChromeDriver();
            ScenarioContext.Current["browser"] = driver;
        }

        [AfterScenario]
        public static void CloseBrowser()
        {
            IWebDriver driver = (IWebDriver)ScenarioContext.Current["browser"];
            driver.Quit();
        }
    }
}
