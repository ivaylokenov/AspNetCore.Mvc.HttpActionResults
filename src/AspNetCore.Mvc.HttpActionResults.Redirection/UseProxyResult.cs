namespace Microsoft.AspNetCore.Mvc
{
    using System;
    using System.Threading.Tasks;

    using Http;

    using Microsoft.Extensions.Primitives;
    using Microsoft.Net.Http.Headers;

    /// <summary>
    /// An <see cref="StatusCodeResult"/> that when executed will produce an empty
    /// <see cref="StatusCodes.Status305UseProxy"/> response.
    /// </summary>
    public class UseProxyResult : StatusCodeResult
    {
        private string proxyUri;

        /// <summary>
        /// Initializes a new instance of the <see cref="UseProxyResult"/> class.
        /// </summary>
        /// <param name="proxyUri">A proxy through which the requested resource must be accessed.</param>
        public UseProxyResult(string proxyUri)
            : base(StatusCodes.Status305UseProxy)
        {
            this.ProxyUri = proxyUri;
        }

        /// <summary>
        /// A proxy through which the requested resource must be accessed.
        /// </summary>
        public string ProxyUri
        {
            get
            {
                return this.proxyUri;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                this.proxyUri = value;
            }
        }

        /// <inheritdoc />
        public override Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.Headers.Add(
                HeaderNames.Location,
                new StringValues(this.ProxyUri));

            return base.ExecuteResultAsync(context);
        }
    }
}
