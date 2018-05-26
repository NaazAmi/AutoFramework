using TechTalk.SpecFlow;
using ERMPower.Pages;
using TechTalk.SpecFlow.Assist;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
namespace ERMPower.Steps
{
    [Binding]
   public class APITestSteps
    {
        [Given(@"I have Connected with Posts API")]
        public void GivenIHaveConnectedWithPostsAPI()
        {
            APIPage apiPage = new APIPage();
        }

        [Given(@"I Check Posts Data")]
        public void GivenICheckPostsData(Table table)
        {
            string response = new APIPage().ReadResponse();
            dynamic data = table.CreateDynamicInstance();

            VerifyTextExists(data.title.ToString(), response.ToString());
            
        }
        public static void VerifyTextExists(string expResult, string actResult)
        {
            if (!actResult.Contains(expResult))
                throw new Exception(string.Format("Expected Data Not Found!"));
        }
        

    }
}
