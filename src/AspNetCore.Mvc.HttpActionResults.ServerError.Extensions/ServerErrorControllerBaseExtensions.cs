namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// Class containing server error HTTP response extensions methods for <see cref="ControllerBase"/>. 
    /// </summary>
    public static class ServerErrorControllerBaseExtensions
    {
        /// <summary>
        /// Creates an <see cref="NotImplementedResult"/> object that produces an Not Implemented (501) response.
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
