using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Framework.Base;
using Framework.Extensions;

namespace ERMPower.Pages
{
    class HomePage : BasePage
    {
        [FindsBy(How = How.LinkText, Using = "Log in")]
        IWebElement lnkLogin { get; set; }

        public LoginPage ClickLogin()
        {
            lnkLogin.Click();
            return GetInstance<LoginPage>();
        }

        public void CheckLoginLinkExists()
        {
            lnkLogin.AssertElementPresent();
        }

        [FindsBy(How = How.LinkText, Using = "Log out")]
        public IWebElement ClickLogout { get; set; }

        public LoginPage ClickLogoutLink()
        {
            ClickLogout.Click();
            return GetInstance<LoginPage>();
        }

        public void CheckLogoutLinkExists()
        {
            ClickLogout.AssertElementPresent();
        }
    }
}
