namespace Microsoft.AspNetCore.Mvc
{
    using System.Threading.Tasks;
    using Extensions.Primitives;
    using Http;
    using Net.Http.Headers;

    /// <summary>
    /// An <see cref="StatusCodeResult"/>  that when executed will produce an empty
    /// <see cref="StatusCodes.Status303SeeOther"/> response.
    /// </summary>
    public class SeeOtherResult : StatusCodeResult
    {
        private readonly string location;

        /// <summary>
        /// Initializes a new instance of the <see cref="SeeOtherResult"/> class.
        /// </summary>
        public SeeOtherResult()
            : base(StatusCodes.Status303SeeOther)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeeOtherResult"/> class.
        /// </summary>
        /// <param name="location">Location to put in the response header.</param>
        public SeeOtherResult(string location)
            : this()
        {
            this.location = location;
        }

        /// <inheritdoc />
        public override Task ExecuteResultAsync(ActionContext context)
        {
            if (!string.IsNullOrEmpty(this.location))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.Location, new StringValues(this.location));
            }

            return base.ExecuteResultAsync(context);
        }
    }
}
