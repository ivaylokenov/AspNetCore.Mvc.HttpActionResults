namespace Microsoft.AspNetCore.Mvc
{
    using System;
    using System.Globalization;
    using System.Threading.Tasks;

    using Extensions.Primitives;
    using Http;
    using Net.Http.Headers;

    /// <summary>
    /// An <see cref="ObjectResult"/> that when executed performs content negotiation, formats the entity body, and
    /// will produce a <see cref="StatusCodes.Status206PartialContent"/> response if negotiation and formatting succeed.
    /// </summary>
    public class PartialContentObjectResult : ObjectResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartialContentObjectResult"/> class.
        /// </summary>
        /// <param name="value">The content to format into the entity body.</param>
        public PartialContentObjectResult(object value)
            : base(value)
        {
            this.StatusCode = StatusCodes.Status206PartialContent;
        }

        /// <summary>
        /// Indicates where in a full body message a partial message belongs.
        /// </summary>
        public string ContentRange { get; set; }

        /// <summary>
        /// An identifier for a specific version of a resource.
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Indicates an alternate location for the returned data.
        /// </summary>
        public string ContentLocation { get; set; }

        /// <summary>
        /// Contains the date/time after which the response is considered stale.
        /// </summary>
        public string Expires { get; set; }

        /// <summary>
        /// Specifies directive for caching mechanisms in the responses.
        /// </summary>
        public string CacheControl { get; set; }

        /// <summary>
        /// Determines how to match future request headers to decide whether a cached response can be used rather than requesting a fresh one from the origin server. 
        /// </summary>
        public string Vary { get; set; }

        /// <inheritdoc />
        public override Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.Headers.Add(
                HeaderNames.Date,
                new StringValues(DateTime.Now.ToString(CultureInfo.InvariantCulture)));

            if (!string.IsNullOrEmpty(this.ContentRange))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.ContentRange, new StringValues(this.ContentRange));
            }

            if (!string.IsNullOrWhiteSpace(this.ETag))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.ETag, new StringValues(this.ETag));
            }

            if (!string.IsNullOrWhiteSpace(this.ContentLocation))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.ContentLocation, new StringValues(this.ContentLocation));
            }

            if (!string.IsNullOrWhiteSpace(this.Expires))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.Expires, new StringValues(this.Expires));
            }

            if (!string.IsNullOrWhiteSpace(this.CacheControl))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.CacheControl, new StringValues(this.CacheControl));
            }

            if (!string.IsNullOrWhiteSpace(this.Vary))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.Vary, new StringValues(this.Vary));
            }

            return base.ExecuteResultAsync(context);
        }
    }
}
