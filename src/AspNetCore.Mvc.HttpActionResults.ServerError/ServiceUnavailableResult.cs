namespace Microsoft.AspNetCore.Mvc
{
    using Extensions.Primitives;
    using Http;
    using Net.Http.Headers;
    using System.Threading.Tasks;

    /// <summary>
    /// An <see cref="StatusCodeResult"/> that when executed will produce a
    /// <see cref="StatusCodes.Status503ServiceUnavailable"/> response.
    /// </summary>
    public class ServiceUnavailableResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUnavailableResult"/> class.
        /// </summary>
        public ServiceUnavailableResult()
            : base(StatusCodes.Status503ServiceUnavailable)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUnavailableResult"/> class.
        /// </summary>
        /// <param name="lengthOfDelay">Length of delay to put in the response header.</param>
        public ServiceUnavailableResult(string lengthOfDelay)
            : this()
        {
            this.LengthOfDelay = lengthOfDelay;
        }

        /// <summary>
        /// Gets or sets the location to put in the response header.
        /// </summary>
        public string LengthOfDelay { get; set; }

        /// <inheritdoc />
        public override Task ExecuteResultAsync(ActionContext context)
        {
            if (!string.IsNullOrWhiteSpace(this.LengthOfDelay))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.RetryAfter, new StringValues(this.LengthOfDelay));
            }

            return base.ExecuteResultAsync(context);
        }
    }
}
