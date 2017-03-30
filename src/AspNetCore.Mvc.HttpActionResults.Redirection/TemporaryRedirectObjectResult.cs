namespace Microsoft.AspNetCore.Mvc
{
    using System;
    using System.Threading.Tasks;

    using Http;

    using Microsoft.Extensions.Primitives;
    using Microsoft.Net.Http.Headers;

    /// <summary>
    /// An <see cref="ObjectResult"/> that when executed performs content negotiation, formats the entity body, and
    /// will produce a <see cref="StatusCodes.Status307TemporaryRedirect"/> response if negotiation and formatting succeed.
    /// </summary>
    public class TemporaryRedirectObjectResult : ObjectResult
    {
        private string temporaryUri;

        /// <summary>
        /// Initializes a new instance of the <see cref="TemporaryRedirectObjectResult"/> class.
        /// </summary>
        /// <param name="value">The content to format into the entity body.</param>
        /// <param name="temporaryUri">The temporary URI of the requested resource resides.</param>
        public TemporaryRedirectObjectResult(object value, string temporaryUri)
            : base(value)
        {
            this.StatusCode = StatusCodes.Status307TemporaryRedirect;
            this.TemporaryUri = temporaryUri;
        }

        /// <summary>
        /// The temporary URI of the requested resource resides.
        /// </summary>
        public string TemporaryUri
        {
            get
            {
                return this.temporaryUri;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                this.temporaryUri = value;
            }
        }

        /// <summary>
        /// Contains the date/time after which the response is considered stale.
        /// </summary>
        public string Expires { get; set; }

        /// <summary>
        /// Specifies directive for caching mechanisms in the responses.
        /// </summary>
        public string CacheControl { get; set; }

        /// <inheritdoc />
        public override Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.Headers.Add(
                HeaderNames.Location,
                new StringValues(this.TemporaryUri));

            if (!string.IsNullOrWhiteSpace(this.Expires))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.Expires, new StringValues(this.Expires));
            }

            if (!string.IsNullOrWhiteSpace(this.CacheControl))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.CacheControl, new StringValues(this.CacheControl));
            }

            return base.ExecuteResultAsync(context);
        }
    }
}
