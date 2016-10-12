namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// Class containing server error HTTP response extensions methods for <see cref="ControllerBase"/>. 
    /// </summary>
    public static class ServerErrorControllerBaseExtensions
    {
        /// <summary>
        /// Creates a <see cref="NotImplementedResult"/> object that produces a Not Implemented (501) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="NotImplementedResult"/> for the response.</returns>
        public static NotImplementedResult NotImplemented(this ControllerBase controller)
            => new NotImplementedResult();

        /// <summary>
        /// Creates a <see cref="BadGatewayResult"/> object that produces a Bad Getaway (502) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="BadGatewayResult"/> for the response.</returns>
        public static BadGatewayResult BadGateway(this ControllerBase controller)
            => new BadGatewayResult();

        /// <summary>
        /// Creates a <see cref="ServiceUnavailableResult"/> object that produces an empty Service Unavailable (503) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="ServiceUnavailableResult"/> for the response.</returns>
        public static ServiceUnavailableResult ServiceUnavailable(this ControllerBase controller)
             => new ServiceUnavailableResult();

        /// <summary>
        /// Creates a <see cref="ServiceUnavailableResult"/> object that produces a Service Unavailable (503) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="lengthOfDelay">Length of delay after which the server will be running again.</param>
        /// <returns>The created <see cref="ServiceUnavailableResult"/> for the response.</returns>
        public static ServiceUnavailableResult ServiceUnavailable(this ControllerBase controller, string lengthOfDelay)
             => new ServiceUnavailableResult(lengthOfDelay);

        /// <summary>
        /// Creates a <see cref="GatewayTimeoutResult"/> object that produces a Gateway Timeout (504) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="GatewayTimeoutResult"/> for the response.</returns>
        public static GatewayTimeoutResult GatewayTimeout(this ControllerBase controller)
            => new GatewayTimeoutResult();

        /// <summary>
        /// Creates a <see cref="HTTPVersionNotSupportedResult"/> object that produces a HTTP Version Not Supported (505) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="value">The precondition failed value to format in the entity body.</param>
        /// <returns>The created <see cref="HTTPVersionNotSupportedResult"/> for the response.</returns>
        public static HTTPVersionNotSupportedResult HTTPVersionNotSupported(this ControllerBase controller, object value)
            => new HTTPVersionNotSupportedResult(value);
    }
}
