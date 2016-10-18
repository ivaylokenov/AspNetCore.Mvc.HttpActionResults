namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce an
    /// <see cref="StatusCodes.Status418ImATeapot"/> response.
    /// </summary>
    public class ImATeapotResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImATeapotResult"/> class.
        /// </summary>
        public ImATeapotResult()
            : base(StatusCodes.Status418ImATeapot)
        {
        }
    }
}
