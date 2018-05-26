using System;
using System.IO;
using System.Net;

public enum Verb
{
    GET,
    POST,
    PUT,
    DELETE
}

namespace Framework.Helpers
{
    public class RestAPIHelpers
    {
        public string EndPoint { get; set; }
        public Verb Method { get; set; }
        public string ContentType { get; set; }
        public string PostData { get; set; }

        public RestAPIHelpers()
        {
            EndPoint = "";
            Method = Verb.GET;
            ContentType = "application/JSON";
            PostData = "";
        }

        public RestAPIHelpers(string endpoint, Verb method, string postData)
        {
            EndPoint = endpoint;
            Method = method;
            ContentType = "text/json";
            PostData = postData;
        }

        public string Request()
        {
            return Request("");
        }

        public string Request(string parameters)
        {
            var request = (HttpWebRequest)WebRequest.Create(EndPoint + parameters);
            request.Method = Method.ToString();
            request.ContentLength = 0;
            request.ContentType = ContentType;

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                var responseValue = string.Empty;

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var message = String.Format("Faile: Received HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                        using (var reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                            Console.WriteLine(responseValue);
                            Console.WriteLine("Done");
                        }
                }

                return responseValue;
            }
        }
    }
}
