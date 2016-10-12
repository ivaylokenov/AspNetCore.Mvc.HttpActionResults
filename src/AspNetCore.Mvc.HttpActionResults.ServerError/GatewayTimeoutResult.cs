namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce a
    /// <see cref="StatusCodes.Status504GatewayTimeout"/> response.
    /// </summary>
    public class GatewayTimeoutResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayTimeoutResult"/> class.
        /// </summary>
        public GatewayTimeoutResult()
            : base(StatusCodes.Status504GatewayTimeout)
        {
        }
    }
}
