namespace WebApplicationRequestTypeExample
{
    public class WebApplication
    {
        private BrowserType _browserType;

        public WebApplication(BrowserType browserType)
        {
            _browserType = browserType;
        }

        public AsyncReponse SendAsyncRequestToServer(string url)
        {
            IAsyncRequestStrategy asyncRequestStrategy;
            AsyncReponse asyncReponse = null;
            switch(_browserType)
            {
                case BrowserType.InternetExplorer:
                    asyncRequestStrategy = new XmlHttpRequestApi();
                    return asyncRequestStrategy.SendRequest(url, BrowserType.InternetExplorer.ToString());
                case BrowserType.GoogleChrome:
                    asyncRequestStrategy = new FetchApi();
                    return asyncRequestStrategy.SendRequest(url, BrowserType.GoogleChrome.ToString());
            }

            return asyncReponse;
        }

    }
}