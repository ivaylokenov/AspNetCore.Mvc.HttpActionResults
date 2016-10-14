namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce an empty
    /// <see cref="StatusCodes.Status409Conflict"/> response.
    /// </summary>
    public class ConflictResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConflictResult"/> class.
        /// </summary>
        public ConflictResult()
            : base(StatusCodes.Status409Conflict)
        {
        }
    }
}
