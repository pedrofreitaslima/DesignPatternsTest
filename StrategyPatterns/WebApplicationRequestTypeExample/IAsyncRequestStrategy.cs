namespace WebApplicationRequestTypeExample
{
    public interface IAsyncRequestStrategy
    {
        AsyncReponse SendRequest(string url, string browser);
    }
}