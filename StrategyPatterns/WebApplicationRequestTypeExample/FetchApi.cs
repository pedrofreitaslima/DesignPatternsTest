using System;

namespace WebApplicationRequestTypeExample
{
    public class FetchApi : IAsyncRequestStrategy
    {
        public AsyncReponse SendRequest(string url, string browser)
        {
            AsyncReponse asyncReponse = new AsyncReponse();
            Console.WriteLine("{0} - Sent async network request using Fetch API to - {1}", browser, url);
            return asyncReponse;
        }
    }
}