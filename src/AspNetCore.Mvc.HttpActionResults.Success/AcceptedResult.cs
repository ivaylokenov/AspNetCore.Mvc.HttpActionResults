namespace Microsoft.AspNetCore.Mvc
{
    using System.Threading.Tasks;
    using Extensions.Primitives;
    using Http;
    using Net.Http.Headers;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce an empty
    /// <see cref="StatusCodes.Status202Accepted"/> response.
    /// </summary>
    public class AcceptedResult : StatusCodeResult
    {
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
            this.Location = location;
        }

        /// <summary>
        /// Gets or sets the location to put in the response header.
        /// </summary>
        public string Location { get; set; }

        /// <inheritdoc />
        public override Task ExecuteResultAsync(ActionContext context)
        {
            if (!string.IsNullOrEmpty(this.Location))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.Location, new StringValues(this.Location));
            }

            return base.ExecuteResultAsync(context);
        }
    }
}
