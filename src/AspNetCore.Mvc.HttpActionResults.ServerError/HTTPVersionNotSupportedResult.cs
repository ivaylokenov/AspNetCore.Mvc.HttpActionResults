namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// An <see cref="ObjectResult"/> that when executed performs content negotiation, formats the entity body, and
    /// will produce a <see cref="StatusCodes.Status505HttpVersionNotsupported"/> response if negotiation and formatting succeed.
    /// </summary>
    public class HTTPVersionNotSupportedResult : ObjectResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPVersionNotSupportedResult"/> class.
        /// </summary>
        public HTTPVersionNotSupportedResult(object value)
            : base(value)
        {
            this.StatusCode = StatusCodes.Status505HttpVersionNotsupported;
        }
    }
}
