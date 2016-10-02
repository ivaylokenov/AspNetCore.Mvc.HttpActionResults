namespace Microsoft.AspNetCore.Mvc
{
    using Http;
    using Extensions.Primitives;
    using Net.Http.Headers;

    /// <summary>
    /// An <see cref="ObjectResult"/> that when executed performs content negotiation, formats the entity body, and
    /// will produce a <see cref="StatusCodes.Status202Accepted"/> response if negotiation and formatting succeed.
    /// </summary>
    public class AcceptedObjectResult : ObjectResult
    {
        private readonly string location;

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptedObjectResult"/> class.
        /// </summary>
        /// <param name="value">The content to format into the entity body.</param>
        public AcceptedObjectResult(object value)
            : base(value)
        {
            this.StatusCode = StatusCodes.Status202Accepted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptedObjectResult"/> class.
        /// </summary>
        /// <param name="location">Location to put in the response header.</param>
        /// <param name="value">The content to format into the entity body.</param>
        public AcceptedObjectResult(string location, object value)
            : this(value)
        {
            this.location = location;
        }

        /// <inheritdoc />
        public override void OnFormatting(ActionContext context)
        {
            base.OnFormatting(context);

            if (!string.IsNullOrEmpty(this.location))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.Location, new StringValues(this.location));
            }
        }
    }
}