namespace Microsoft.AspNetCore.Mvc
{
    using Extensions.Primitives;
    using Http;
    using Net.Http.Headers;

    /// <summary>
    /// An <see cref="ObjectResult"/> that when executed performs content negotiation, formats the entity body, and
    /// will produce a <see cref="StatusCodes.Status303SeeOther"/> response if negotiation and formatting succeed.
    /// </summary>
    public class SeeOtherObjectResult : ObjectResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeeOtherObjectResult"/> class.
        /// </summary>
        /// <param name="value">The content to format into the entity body.</param>
        public SeeOtherObjectResult(object value)
            : base(value)
        {
            this.StatusCode = StatusCodes.Status303SeeOther;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeeOtherObjectResult"/> class.
        /// </summary>
        /// <param name="location">Location to put in the response header.</param>
        /// <param name="value">The content to format into the entity body.</param>
        public SeeOtherObjectResult(string location, object value)
            : this(value)
        {
            this.Location = location;
        }

        /// <summary>
        /// Gets or sets the location to put in the response header.
        /// </summary>
        public string Location { get; set; }

        /// <inheritdoc />
        public override void OnFormatting(ActionContext context)
        {
            base.OnFormatting(context);

            if (!string.IsNullOrEmpty(this.Location))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.Location, new StringValues(this.Location));
            }
        }
    }
}