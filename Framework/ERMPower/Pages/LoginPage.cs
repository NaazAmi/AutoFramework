using OpenQA.Selenium; 
using OpenQA.Selenium.Support.PageObjects;
using Framework.Base;
using Framework.Extensions;

namespace ERMPower.Pages
{
    class LoginPage : BasePage
    {
        
        [FindsBy(How = How.Id, Using = "ctl00_ctl00_cph1_cph1_ctrlCustomerLogin_LoginForm_UserName")]
        IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_cph1_cph1_ctrlCustomerLogin_LoginForm_Password")]
        IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_cph1_cph1_ctrlCustomerLogin_LoginForm_RememberMe")]
        IWebElement chkPasswordRemember { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_cph1_cph1_ctrlCustomerLogin_LoginForm_LoginButton")]
        IWebElement btnLogin { get; set; }

       
       
        public void Login(string UserName, string Password)
        {
            txtUserName.SendKeys(UserName);
            txtPassword.SendKeys(Password);
            chkPasswordRemember.Click();
        }

        public HomePage ClickLoginButton()
        {
            btnLogin.Submit();
            return GetInstance<HomePage>();
        }
    }
}
