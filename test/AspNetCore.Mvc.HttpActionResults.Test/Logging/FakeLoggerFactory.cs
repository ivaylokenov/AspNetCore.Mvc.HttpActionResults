namespace AspNetCore.Mvc.HttpActionResults.Test.Logging
{
    using Microsoft.Extensions.Logging;

    public class FakeLoggerFactory : ILoggerFactory
    {
        public static readonly FakeLoggerFactory Instance = new FakeLoggerFactory();

        public ILogger CreateLogger(string name)
        {
            return FakeLogger.Instance;
        }

        public void AddProvider(ILoggerProvider provider)
        {
        }

        public void Dispose()
        {
        }
    }
}
