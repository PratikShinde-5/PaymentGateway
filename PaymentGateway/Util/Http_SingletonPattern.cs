public class Http_SingletonPattern
{
    private static object _locker = new object();
    private static volatile HttpClient _client;
    public static string Host;
    private static HttpClientHandler handler;

    public static HttpClient Client
    {
        get
        {
            if (_client == null)
            {
                lock (_locker)
                {
                    if (_client == null)
                    {
                        _client = new HttpClient();
                    }
                }
            }
            return _client;
        }
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    //Displose the Object

    public virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (_client != null)
            {
                _client.Dispose();
            }

            _client = null;
        }
    }
}