namespace Microsoft.AspNetCore.Mvc
{
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce a
    /// <see cref="StatusCodes.Status203NonAuthoritative"/> response.
    /// </summary>
    public class NonAuthoritativeInformationResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NonAuthoritativeInformationResult"/> class.
        /// </summary>
        public NonAuthoritativeInformationResult()
            : base(StatusCodes.Status203NonAuthoritative)
        {
        }
    }
}
