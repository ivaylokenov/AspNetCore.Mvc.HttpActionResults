namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// Class containing redirection HTTP response extensions methods for <see cref="ControllerBase"/>. 
    /// </summary>
    public static class RedirectionControllerBaseExtensions
    {
        /// <summary>
        /// Creates an <see cref="MultipleChoicesResult"/> object that produces a Multiple Choices (300) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="preferedChoiceUri">Preferred resource choice represented as an URI.</param>
        /// <returns>The created <see cref="MultipleChoicesResult"/> for the response.</returns>
        public static MultipleChoicesResult MultipleChoices(this ControllerBase controller, string preferedChoiceUri = null)
            => new MultipleChoicesResult(preferedChoiceUri);

        /// <summary>
        /// Creates an <see cref="MultipleChoicesObjectResult"/> object that produces a Multiple Choices (300) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="value">List of resource characteristics and location(s) to format in the entity body.</param>
        /// <param name="preferedChoiceUri">Preferred resource choice represented as an URI.</param>
        /// <returns>The created <see cref="MultipleChoicesObjectResult"/> for the response.</returns>
        public static MultipleChoicesObjectResult MultipleChoices(
            this ControllerBase controller,
            object value,
            string preferedChoiceUri = null)
            => new MultipleChoicesObjectResult(value);

        /// <summary>
        /// Creates an <see cref="SeeOtherResult"/> object that produces a See Other (303) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="SeeOtherResult"/> for the response.</returns>
        public static SeeOtherResult SeeOther(this ControllerBase controller)
            => new SeeOtherResult();

        /// <summary>
        /// Creates an <see cref="SeeOtherResult"/> object that produces a See Other (303) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="uri">The URI at which the content has been created.</param>
        /// <returns>The created <see cref="SeeOtherResult"/> for the response.</returns>
        public static SeeOtherResult SeeOther(this ControllerBase controller, string uri)
            => new SeeOtherResult(uri);

        /// <summary>
        /// Creates an <see cref="SeeOtherObjectResult"/> object that produces a See Other (303) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="value">The accepted value to format in the entity body.</param>
        /// <returns>The created <see cref="SeeOtherObjectResult"/> for the response.</returns>
        public static SeeOtherObjectResult SeeOther(this ControllerBase controller, object value)
            => new SeeOtherObjectResult(value);

        /// <summary>
        /// Creates an <see cref="SeeOtherObjectResult"/> object that produces a See Other (303) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="uri">The URI at which the content has been created.</param>
        /// <param name="value">The accepted value to format in the entity body.</param>
        /// <returns>The created <see cref="SeeOtherObjectResult"/> for the response.</returns>
        public static SeeOtherObjectResult SeeOther(this ControllerBase controller, string uri, object value)
            => new SeeOtherObjectResult(uri, value);

        /// <summary>
        /// Creates an <see cref="NotModifiedResult"/> object that produces a Not Modified (304) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="NotModifiedResult"/> for the response.</returns>
        public static NotModifiedResult NotModified(this ControllerBase controller)
            => new NotModifiedResult();

        /// <summary>
        /// Creates an <see cref="UseProxyResult"/> object that produces a Use Proxy (305) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="proxyUri">A proxy through which the requested resource must be accessed.</param>
        /// <returns>The created <see cref="UseProxyResult"/> for the response.</returns>
        public static UseProxyResult UseProxy(this ControllerBase controller, string proxyUri)
            => new UseProxyResult(proxyUri);
    }
}
