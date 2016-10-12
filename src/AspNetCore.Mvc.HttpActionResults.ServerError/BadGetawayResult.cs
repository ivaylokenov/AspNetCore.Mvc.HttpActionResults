namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce a
    /// <see cref="StatusCodes.Status502BadGateway"/> response.
    /// </summary>
    public class BadGetawayResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadGetawayResult"/> class.
        /// </summary>
        public BadGetawayResult()
            : base(StatusCodes.Status502BadGateway)
        {
        }
    }
}
