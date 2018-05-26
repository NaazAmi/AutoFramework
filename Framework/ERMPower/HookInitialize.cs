using Framework.Base;
using TechTalk.SpecFlow;
namespace ERMPower
{
    [Binding]
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize(): base(BrowserType.Firefox)
        {
            InitializeSettings();

           // navigateSite();
        }

        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();
        }

        [AfterFeature]
        public static void CloseBrowser()
        {
            DriverContext.Driver.Close();
        }
    }
}
