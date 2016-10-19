namespace Microsoft.AspNetCore.Mvc
{
    using System;

    using Http;

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
        /// <param name="includeErrorDetail">
        /// <see langword="true"/> if the error should include exception messages; otherwise, <see langword="false"/>.
        /// </param>
        public ExceptionResult(Exception exception, bool includeErrorDetail)
            : base(exception)
        {
            if (exception == null)
            {
                throw new ArgumentNullException(nameof(exception));
            }
            
            if (includeErrorDetail)
            {
                this.Value = exception;
            }
            else
            {
                this.Value = exception.Message;
            }

            this.Exception = exception;
            this.StatusCode = StatusCodes.Status500InternalServerError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionResult"/> class.
        /// </summary>
        /// <param name="exception">The exception to include in the error.</param>
        public ExceptionResult(Exception exception)
            : this(exception, false)
        {
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
