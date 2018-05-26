using System;
using OpenQA.Selenium;

namespace Framework.Extensions
{
    public static class WebElementExtensions
    {
        public static void AssertElementPresent(this IWebElement element)
        {
            if (!IsElementPresent(element))
                throw new Exception(string.Format("Element Not Present Exception!"));
        }
        private static bool IsElementPresent(IWebElement element)
        {
            try
            {
                bool ele = element.Displayed;
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
