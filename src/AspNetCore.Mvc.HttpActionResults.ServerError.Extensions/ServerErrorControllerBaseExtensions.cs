namespace Microsoft.AspNetCore.Mvc
{
    using System;

    /// <summary>
    /// Class containing server error HTTP response extensions methods for <see cref="ControllerBase"/>. 
    /// </summary>
    public static class ServerErrorControllerBaseExtensions
    {
        /// <summary>
        /// Creates an <see cref="InternalServerErrorResult"/> object that produces an Internal Server Error (500) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="InternalServerErrorResult"/> for the response.</returns>
        public static InternalServerErrorResult InternalServerError(this ControllerBase controller)
            => new InternalServerErrorResult();

        /// <summary>
        /// Creates an <see cref="ExceptionResult"/> object that produces an Internal Server Error (500) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="exception">The exception to include in the error.</param>
        /// <returns>The created <see cref="ExceptionResult"/> for the response.</returns>
        public static ExceptionResult InternalServerError(this ControllerBase controller, Exception exception)
        {
            if (exception == null)
            {
                throw new ArgumentNullException(nameof(exception));
            }

            return new ExceptionResult(exception);
        }

		/// <summary>
		/// Creates an <see cref="ExceptionResult"/> object that produces an Internal Server Error (500) response.
		/// </summary>
		/// <param name="controller">MVC controller instance.</param>
		/// <param name="exception">The exception to include in the error.</param>
		/// <param name="includeErrorDetail">
		/// <see langword="true"/> if the error should include exception messages; otherwise, <see langword="false"/>.
		/// </param>
		/// <returns>The created <see cref="ExceptionResult"/> for the response.</returns>
		public static ExceptionResult InternalServerError(this ControllerBase controller, Exception exception, bool includeErrorDetail)
		{
			if (exception == null)
			{
				throw new ArgumentNullException(nameof(exception));
			}

			return new ExceptionResult(exception, includeErrorDetail);
		}

		/// <summary>
		/// Creates an <see cref="NotImplementedResult"/> object that produces a Not Implemented (501) response.
		/// </summary>
		/// <param name="controller">MVC controller instance.</param>
		/// <returns>The created <see cref="NotImplementedResult"/> for the response.</returns>
		public static NotImplementedResult NotImplemented(this ControllerBase controller)
            => new NotImplementedResult();

        /// <summary>
        /// Creates an <see cref="BadGatewayResult"/> object that produces an Bad Getaway (502) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="BadGatewayResult"/> for the response.</returns>
        public static BadGatewayResult BadGateway(this ControllerBase controller)
            => new BadGatewayResult();

        /// <summary>
        /// Creates an <see cref="GatewayTimeoutResult"/> object that produces an Gateway Timeout (504) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="GatewayTimeoutResult"/> for the response.</returns>
        public static GatewayTimeoutResult GatewayTimeout(this ControllerBase controller)
            => new GatewayTimeoutResult();
    }
}
