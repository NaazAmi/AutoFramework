using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace Framework.Base
{
    public abstract class TestInitializeHook
    {
        public readonly BrowserType Browser;
        public TestInitializeHook(BrowserType browser)
        {
            Browser = browser;
        }
        public void InitializeSettings()
        {
            //Open Browser
            OpenBrowser(Browser);
            BaseStep.navigateSite();
        }

        public void OpenBrowser(BrowserType browserType = BrowserType.Firefox)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Firefox:
                    System.Environment.SetEnvironmentVariable("Webdriver.gecko.driver", "..\\..\\geckodriver.exe");
                  //  System.Environment.SetEnvironmentVariable("Webdriver.gecko.driver", @"C:\Users\Naaz\Desktop\AutomationFramework\Framework\geckodriver.exe");
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }
        
    }
}
