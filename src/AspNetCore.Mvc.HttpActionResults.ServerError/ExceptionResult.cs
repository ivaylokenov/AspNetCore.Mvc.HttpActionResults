namespace Microsoft.AspNetCore.Mvc
{
    using Http;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce a
    /// <see cref="StatusCodes.Status500InternalServerError"/> response.
    /// </summary>
    public class ExceptionResult : ObjectResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionResult"/> class.
        /// </summary>
        /// <param name="exception">The exception to include in the error.</param>
        public ExceptionResult(Exception exception)
            : base(exception)
        {
            if (exception == null)
	        {
		        throw new ArgumentNullException(nameof(exception));
	        }

			this.Exception = exception;
			this.StatusCode = StatusCodes.Status500InternalServerError;
        }

        /// <summary>
        /// Gets the exception to include in the error.
        /// </summary>
        public Exception Exception
        {
            get; private set;
        }
    }
}
