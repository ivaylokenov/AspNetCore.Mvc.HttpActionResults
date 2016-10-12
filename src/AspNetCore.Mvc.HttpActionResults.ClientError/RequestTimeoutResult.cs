namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce an empty
    /// <see cref="StatusCodes.Status408RequestTimeout"/> response.
    /// </summary>
    public class RequestTimeoutResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTimeoutResult"/> class.
        /// </summary>
        public RequestTimeoutResult() 
            : base(StatusCodes.Status408RequestTimeout)
        {
        }
    }
}
