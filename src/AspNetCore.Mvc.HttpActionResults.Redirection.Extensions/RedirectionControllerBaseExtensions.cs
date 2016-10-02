namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// Class containing redirection HTTP response extensions methods for <see cref="ControllerBase"/>. 
    /// </summary>
    public static class RedirectionControllerBaseExtensions
    {
        /// <summary>
        /// Creates an <see cref="SeeOtherResult"/> object that produces an See Other (303) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="SeeOtherResult"/> for the response.</returns>
        public static SeeOtherResult SeeOther(this ControllerBase controller)
            => new SeeOtherResult();

        /// <summary>
        /// Creates an <see cref="SeeOtherResult"/> object that produces an See Other (303) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="uri">The URI at which the content has been created.</param>
        /// <returns>The created <see cref="SeeOtherResult"/> for the response.</returns>
        public static SeeOtherResult SeeOther(this ControllerBase controller, string uri)
            => new SeeOtherResult(uri);

        /// <summary>
        /// Creates an <see cref="SeeOtherObjectResult"/> object that produces an See Other (303) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="value">The accepted value to format in the entity body.</param>
        /// <returns>The created <see cref="SeeOtherObjectResult"/> for the response.</returns>
        public static SeeOtherObjectResult SeeOther(this ControllerBase controller, object value)
            => new SeeOtherObjectResult(value);

        /// <summary>
        /// Creates an <see cref="SeeOtherObjectResult"/> object that produces an See Other (303) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="uri">The URI at which the content has been created.</param>
        /// <param name="value">The accepted value to format in the entity body.</param>
        /// <returns>The created <see cref="SeeOtherObjectResult"/> for the response.</returns>
        public static SeeOtherObjectResult SeeOther(this ControllerBase controller, string uri, object value)
            => new SeeOtherObjectResult(uri, value);
    }
}
