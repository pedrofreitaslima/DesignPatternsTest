using System;

namespace WebApplicationRequestTypeExample
{
    public class XmlHttpRequestApi : IAsyncRequestStrategy
    {
        public AsyncReponse SendRequest(string url, string browser)
        {
            AsyncReponse asyncReponse = new AsyncReponse();
            Console.WriteLine("{0} - Sent async network request using XHR to - {1}", browser, url);
            return asyncReponse;
        }
    }
}