namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce an empty
    /// <see cref="StatusCodes.Status414RequestUriTooLong"/> response.
    /// </summary>
    public class RequestUriTooLongResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestUriTooLongResult"/> class.
        /// </summary>
        public RequestUriTooLongResult() 
            : base(StatusCodes.Status414RequestUriTooLong)
        {
        }
    }
}
