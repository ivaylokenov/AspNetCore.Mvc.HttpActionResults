namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce a
    /// <see cref="StatusCodes.Status500InternalServerError"/> response.
    /// </summary>
    public class InternalServerErrorResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalServerErrorResult"/> class.
        /// </summary>
        public InternalServerErrorResult()
            : base(StatusCodes.Status500InternalServerError)
        {
        }
    }
}
