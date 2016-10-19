namespace Microsoft.AspNetCore.Mvc
{
    using System;
    using System.Threading.Tasks;

    using Http;
    using Extensions.Primitives;
    using Net.Http.Headers;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce an empty
    /// <see cref="StatusCodes.Status413RequestEntityTooLarge"/> response.
    /// </summary>
    public class RequestEntityTooLargeResult : StatusCodeResult
    {
        private string retryAfter;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestEntityTooLargeResult"/> class.
        /// </summary>
        public RequestEntityTooLargeResult() 
            : base(StatusCodes.Status413RequestEntityTooLarge)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestEntityTooLargeResult"/> class.
        /// </summary>
        /// <param name="retryAfter">The time after which the client may try the request again.</param>
        public RequestEntityTooLargeResult(string retryAfter)
            : this()
        {
            this.RetryAfter = retryAfter;
        }

        /// <summary>
        /// Gets or sets the the time after which the client may try the request again.
        /// </summary>
        public string RetryAfter
        {
            get
            {
                return this.retryAfter;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(value));
                }

                this.retryAfter = value;
            }
        }

        /// <inheritdoc />
        public override Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.Headers.Add(HeaderNames.RetryAfter, new StringValues(this.RetryAfter));

            return base.ExecuteResultAsync(context);
        }
    }
}
