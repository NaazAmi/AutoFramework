using Framework.Config;

namespace Framework.Base
{
    public abstract class BaseStep : Base
    {
        public static void navigateSite()
        {
            DriverContext.Browser.GoToURL(ConfigReader.InitializeTest());
        }
    }
}
