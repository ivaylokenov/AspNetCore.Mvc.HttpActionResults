namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// Class containing success HTTP response extensions methods for <see cref="ControllerBase"/>. 
    /// </summary>
    public static class SuccessControllerBaseExtensions
    {
        /// <summary>
        /// Creates an <see cref="AcceptedResult"/> object that produces an Accepted (202) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="AcceptedResult"/> for the response.</returns>
        public static AcceptedResult Accepted(this ControllerBase controller)
            => new AcceptedResult();

        /// <summary>
        /// Creates an <see cref="AcceptedResult"/> object that produces an Accepted (202) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="uri">The URI at which the content has been accepted.</param>
        /// <returns>The created <see cref="AcceptedResult"/> for the response.</returns>
        public static AcceptedResult Accepted(this ControllerBase controller, string uri)
            => new AcceptedResult(uri);

        /// <summary>
        /// Creates an <see cref="AcceptedObjectResult"/> object that produces an Accepted (202) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="value">The accepted value to format in the entity body.</param>
        /// <returns>The created <see cref="AcceptedObjectResult"/> for the response.</returns>
        public static AcceptedObjectResult Accepted(this ControllerBase controller, object value)
            => new AcceptedObjectResult(value);

        /// <summary>
        /// Creates an <see cref="AcceptedObjectResult"/> object that produces an Accepted (202) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="uri">The URI at which the content has been accepted.</param>
        /// <param name="value">The accepted value to format in the entity body.</param>
        /// <returns>The created <see cref="AcceptedObjectResult"/> for the response.</returns>
        public static AcceptedObjectResult Accepted(this ControllerBase controller, string uri, object value)
            => new AcceptedObjectResult(uri, value);
    }
}
