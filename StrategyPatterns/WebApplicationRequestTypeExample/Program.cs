using System;

namespace WebApplicationRequestTypeExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            WebApplication webApplication1 = new WebApplication(BrowserType.InternetExplorer);
            webApplication1.SendAsyncRequestToServer("https://www.bing.com");
            WebApplication webApplication2 = new WebApplication(BrowserType.GoogleChrome);
            webApplication2.SendAsyncRequestToServer("https://www.google.com");
        }
    }
}
