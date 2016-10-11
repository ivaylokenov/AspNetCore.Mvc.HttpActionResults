namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// An <see cref="StatusCodeResult"/>  that when executed will produce an empty
    /// <see cref="StatusCodes.Status304NotModified"/> response.
    /// </summary>
    public class NotModifiedResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotModifiedResult"/> class.
        /// </summary>
        public NotModifiedResult()
            : base(StatusCodes.Status304NotModified)
        {
        }
    }
}
