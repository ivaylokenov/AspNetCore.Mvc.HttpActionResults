namespace Microsoft.AspNetCore.Mvc
{
    using Http;
    using Net.Http.Headers;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce an empty
    /// <see cref="StatusCodes.Status416RequestedRangeNotSatisfiable"/> response.
    /// </summary>
    public class RequestedRangeNotSatisfiableResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestedRangeNotSatisfiableResult"/> class.
        /// </summary>
        public RequestedRangeNotSatisfiableResult()
            : base(StatusCodes.Status416RequestedRangeNotSatisfiable)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestedRangeNotSatisfiableResult"/> class.
        /// </summary>
        /// <param name="selectedResourceLength"></param>
        public RequestedRangeNotSatisfiableResult(long selectedResourceLength)
            : this()
        {
        }

        /// <summary>
        /// Gets or sets the current length of the selected resource.
        /// </summary>
        public long SelectedResourceLength { get; set; }

        /// <inheritdoc />
        public override Task ExecuteResultAsync(ActionContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (this.SelectedResourceLength > 0)
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.ContentRange, new Extensions.Primitives.StringValues(this.SelectedResourceLength.ToString()));
            }

            return base.ExecuteResultAsync(context);
        }
    }
}
