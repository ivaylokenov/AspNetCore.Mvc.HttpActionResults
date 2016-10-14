namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce a
    /// <see cref="StatusCodes.Status205ResetContent"/> response.
    /// </summary>
    public class ResetContentResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetContentResult"/> class.
        /// </summary>
        public ResetContentResult()
            : base(StatusCodes.Status205ResetContent)
        {
        }
    }
}
