﻿using OpenQA.Selenium;

namespace Framework.Base
{
    public class Browser
    {
        private readonly IWebDriver _driver;

        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }

        public BrowserType Type { get; set; }

        public void GoToURL(string url)
        {
            DriverContext.Driver.Url = url;
        }
    }
    public enum BrowserType
    {
        InternetExplorer,
        Firefox,
        Chrome
    }
}
