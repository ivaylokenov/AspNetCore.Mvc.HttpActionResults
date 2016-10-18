namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce an empty
    /// <see cref="StatusCodes.Status410Gone"/> response.
    /// </summary>
    public class GoneResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoneResult"/> class.
        /// </summary>
        public GoneResult() 
            : base(StatusCodes.Status410Gone)
        {
        }
    }
}
