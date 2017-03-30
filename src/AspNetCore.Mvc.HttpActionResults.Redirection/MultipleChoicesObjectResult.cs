namespace Microsoft.AspNetCore.Mvc
{
    using System.Threading.Tasks;

    using Http;

    using Microsoft.Extensions.Primitives;
    using Microsoft.Net.Http.Headers;

    /// <summary>
    /// An <see cref="ObjectResult"/> that when executed performs content negotiation, formats the entity body, and
    /// will produce a <see cref="StatusCodes.Status300MultipleChoices"/> response if negotiation and formatting succeed.
    /// </summary>
    public class MultipleChoicesObjectResult : ObjectResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleChoicesObjectResult"/> class.
        /// </summary>
        /// <param name="value">The content to format into the entity body.</param>
        /// <param name="preferedChoiceUri">Preferred resource choice represented as an URI.</param>
        public MultipleChoicesObjectResult(object value, string preferedChoiceUri = null)
            : base(value)
        {
            this.StatusCode = StatusCodes.Status300MultipleChoices;
            this.PreferedChoiceUri = preferedChoiceUri;
        }

        /// <summary>
        /// Preferred resource choice represented as an URI.
        /// </summary>
        public string PreferedChoiceUri { get; set; }

        /// <inheritdoc />
        public override Task ExecuteResultAsync(ActionContext context)
        {

            if (!string.IsNullOrEmpty(this.PreferedChoiceUri))
            {
                context.HttpContext.Response.Headers.Add(HeaderNames.Location, new StringValues(this.PreferedChoiceUri));
            }

            return base.ExecuteResultAsync(context);
        }
    }
}
