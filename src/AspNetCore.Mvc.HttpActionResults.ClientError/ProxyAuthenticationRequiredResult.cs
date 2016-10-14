namespace Microsoft.AspNetCore.Mvc
{
    using System.Threading.Tasks;

    using Http;
    using Extensions.Primitives;
    using Net.Http.Headers;

    /// <summary>
    /// An <see cref="StatusCodeResult"/> that when executed will produce a
    /// <see cref="StatusCodes.Status407ProxyAuthenticationRequired"/> response.
    /// </summary>
    public class ProxyAuthenticationRequiredResult : StatusCodeResult
    {
        /// <summary>
        /// An <see cref="StatusCodeResult"/> that when executed will produce a
        /// Initializes a new instance of the <see cref="ProxyAuthenticationRequiredResult"/> class.
        /// </summary>
        /// <param name="proxyAuthenticate">Challenge applicable to the proxy for the requested resource.</param>
        public ProxyAuthenticationRequiredResult(string proxyAuthenticate)
            : base(StatusCodes.Status407ProxyAuthenticationRequired)
        {
            this.ProxyAuthenticate = proxyAuthenticate;
        }

        /// <summary>
        /// Gets or sets a challenge applicable to the proxy for the requested resource
        /// </summary>
        public string ProxyAuthenticate { get; set; }

        /// <inheritdoc />
        public override Task ExecuteResultAsync(ActionContext context)
        {
            if (!string.IsNullOrWhiteSpace(this.ProxyAuthenticate))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.ProxyAuthenticate, new StringValues(this.ProxyAuthenticate));
            }

            return base.ExecuteResultAsync(context);
        }
    }
}
