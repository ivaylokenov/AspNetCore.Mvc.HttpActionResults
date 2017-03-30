namespace Microsoft.AspNetCore.Mvc
{
    using System;
    using System.Globalization;
    using System.Threading.Tasks;

    using Http;

    using Microsoft.Extensions.Primitives;
    using Microsoft.Net.Http.Headers;

    /// <summary>
    /// An <see cref="StatusCodeResult"/> that when executed will produce an empty
    /// <see cref="StatusCodes.Status300MultipleChoices"/> response.
    /// </summary>
    public class MultipleChoicesResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleChoicesResult"/> class.
        /// </summary>
        /// <param name="preferedChoiceUri">Preferred resource choice represented as an URI.</param>
        public MultipleChoicesResult(string preferedChoiceUri)
            : base(StatusCodes.Status300MultipleChoices)
        {
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
