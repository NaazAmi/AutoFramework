using TechTalk.SpecFlow;
using Framework.Base;
using ERMPower.Pages;
using TechTalk.SpecFlow.Assist;

namespace ERMPower.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {
        [Given(@"I have navigate to the application")]
        public void GivenIHaveNavigateToTheApplication()
        {
            navigateSite();
            CurrentPage = GetInstance<HomePage>();
        }

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            CurrentPage.As<HomePage>().CheckLoginLinkExists();
        }

        [Then(@"I click Login link")]
        public void ThenIClickLoginLink()
        {
            CurrentPage = CurrentPage.As<HomePage>().ClickLogin();
        }

        [When(@"I enter UserName and Password and uncheck Remember password")]
        public void WhenIEnterUserNameAndPasswordAndUncheckRememberPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage.As<LoginPage>().Login(data.UserName, data.Password);
        }

        [Then(@"I click login button")]
        public void ThenIClickLoginButton()
        {
            CurrentPage = CurrentPage.As<LoginPage>().ClickLoginButton();
        }

        [Then(@"Verify User Logged in")]
        public void ThenVerifyUserLoggedIn()
        {
            CurrentPage.As<HomePage>().CheckLogoutLinkExists();
        }


        [Then(@"I should be able to logout")]
        public void ThenIShouldBeAbleToLogout()
        {
            CurrentPage = CurrentPage.As<HomePage>().ClickLogoutLink();
        }

    }
}
