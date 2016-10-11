namespace Microsoft.AspNetCore.Mvc
{
    using Extensions.Primitives;
    using Http;
    using Net.Http.Headers;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce an empty
    /// <see cref="StatusCodes.Status405MethodNotAllowed"/> response.
    /// </summary>
    public class MethodNotAllowedResult : StatusCodeResult
    {
        private string allowedMethods;

        /// <summary>
        /// Initializes a new instance of the <see cref="MethodNotAllowedResult"/> class.
        /// </summary>
        public MethodNotAllowedResult(string allowedMethods)
            : base(StatusCodes.Status405MethodNotAllowed)
        {
            if (string.IsNullOrWhiteSpace(allowedMethods))
            {
                throw new ArgumentException(nameof(allowedMethods));
            }

            this.AllowedMethods = allowedMethods;
        }

        /// <summary>
        /// Gets or sets the value to put in the response <see cref="HeaderNames.Allow"/> header.
        /// </summary>
        public string AllowedMethods
        {
            get
            {
                return this.allowedMethods;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(value));
                }

                this.allowedMethods = value;
            }
        }

        /// <inheritdoc />
        public override Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.Headers.Add(HeaderNames.Allow, new StringValues(this.AllowedMethods));

            return base.ExecuteResultAsync(context);
        }
    }
}
