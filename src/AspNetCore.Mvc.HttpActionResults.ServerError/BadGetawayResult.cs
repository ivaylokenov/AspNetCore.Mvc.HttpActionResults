namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce a
    /// <see cref="StatusCodes.Status502BadGateway"/> response.
    /// </summary>
    public class BadGatewayResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadGatewayResult"/> class.
        /// </summary>
        public BadGatewayResult()
            : base(StatusCodes.Status502BadGateway)
        {
        }
    }
}
