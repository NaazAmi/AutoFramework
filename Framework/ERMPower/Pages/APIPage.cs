using Framework.Helpers;

namespace ERMPower.Pages
{
    class APIPage : RestAPIHelpers
    {
        public APIPage()
        {
            var client = new RestAPIHelpers();

            client.EndPoint = @"https://jsonplaceholder.typicode.com";
            client.Method = Verb.GET;
           // var pdata = client.PostData;
            
        }
        public string ReadResponse()
        {
            var client = new RestAPIHelpers();
            client.EndPoint = @"https://jsonplaceholder.typicode.com";
            client.Method = Verb.GET;
            var response = client.Request("/posts");
            return response;
        }
    }
}
