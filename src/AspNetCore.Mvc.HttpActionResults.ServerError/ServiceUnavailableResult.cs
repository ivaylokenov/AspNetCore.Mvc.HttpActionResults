namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce a
    /// <see cref="StatusCodes.Status503ServiceUnavailable"/> response.
    /// </summary>
    public class ServiceUnavailableResult : StatusCodeResult
    {
        private string lengthOfDelay;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUnavailableResult"/> class.
        /// </summary>
        public ServiceUnavailableResult(string lengthOfDelay)
            : base(StatusCodes.Status503ServiceUnavailable)
        {
            if (string.IsNullOrWhiteSpace(allowedMethods))
            {
                throw new ArgumentException(nameof(allowedMethods));
            }

            this.AllowedMethods = allowedMethods;
        }
    }
}

