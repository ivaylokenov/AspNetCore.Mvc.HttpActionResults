namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce an empty
    /// <see cref="StatusCodes.Status417ExpectationFailed"/> response.
    /// </summary>
    public class ExpectationFailedResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpectationFailedResult"/> class.
        /// </summary>
        public ExpectationFailedResult()
            : base(StatusCodes.Status417ExpectationFailed)
        {
        }
    }
}