namespace Microsoft.AspNetCore.Mvc
{
    using System.Threading.Tasks;
    using Http;
    using Extensions.Primitives;
    using Net.Http.Headers;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce an empty
    /// <see cref="StatusCodes.Status202Accepted"/> response.
    /// </summary>
    public class AcceptedResult : StatusCodeResult
    {
        private readonly string location;

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptedResult"/> class.
        /// </summary>
        public AcceptedResult()
            :base(StatusCodes.Status202Accepted)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptedResult"/> class.
        /// </summary>
        /// <param name="location">Location to put in the response header.</param>
        public AcceptedResult(string location)
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
