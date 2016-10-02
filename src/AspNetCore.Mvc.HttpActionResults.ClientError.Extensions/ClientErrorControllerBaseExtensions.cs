namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// Class containing client error HTTP response extensions methods for <see cref="ControllerBase"/>. 
    /// </summary>
    public static class ClientErrorControllerBaseExtensions
    {
        /// <summary>
        /// Creates an <see cref="PreconditionFailedResult"/> object that produces a Precondition Failed (412) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="PreconditionFailedResult"/> for the response.</returns>
        public static PreconditionFailedResult PreconditionFailed(this ControllerBase controller)
            => new PreconditionFailedResult();

        /// <summary>
        /// Creates an <see cref="PreconditionFailedObjectResult"/> object that produces a Precondition Failed (412) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="value">The precondition failed value to format in the entity body.</param>
        /// <returns></returns>
        public static PreconditionFailedObjectResult PreconditionFailed(this ControllerBase controller, object value)
            => new PreconditionFailedObjectResult(value);

        /// <summary>
        /// Creates an <see cref="UnsupportedMediaTypeResult"/> object that produces an Unsupported Media Type (415) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="UnsupportedMediaTypeResult"/> for the response.</returns>
        public static UnsupportedMediaTypeResult UnsupportedMediaType(this ControllerBase controller)
            => new UnsupportedMediaTypeResult();
    }
}
