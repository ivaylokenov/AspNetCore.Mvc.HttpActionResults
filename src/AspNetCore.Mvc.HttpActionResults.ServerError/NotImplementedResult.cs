namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce a
    /// <see cref="StatusCodes.Status501NotImplemented"/> response.
    /// </summary>
    public class NotImplementedResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotImplementedResult"/> class.
        /// </summary>
        public NotImplementedResult()
            : base(StatusCodes.Status501NotImplemented)
        {
        }
    }
}
