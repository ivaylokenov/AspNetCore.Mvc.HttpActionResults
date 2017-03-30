namespace Microsoft.AspNetCore.Mvc
{
    using Extensions.Primitives;
    using Http;
    using Net.Http.Headers;
    using System.Threading.Tasks;

    /// <summary>
    /// An <see cref="StatusCodeResult"/> that when executed will produce an empty
    /// <see cref="StatusCodes.Status303SeeOther"/> response.
    /// </summary>
    public class SeeOtherResult : StatusCodeResult
    {
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
            this.Location = location;
        }

        /// <summary>
        /// Gets or sets the location to put in the response header.
        /// </summary>
        public string Location { get; set; }

        /// <inheritdoc />
        public override Task ExecuteResultAsync(ActionContext context)
        {
            if (!string.IsNullOrWhiteSpace(this.Location))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.Location, new StringValues(this.Location));
            }

            return base.ExecuteResultAsync(context);
        }
    }
}
