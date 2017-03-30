namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// Class containing success HTTP response extensions methods for <see cref="ControllerBase"/>. 
    /// </summary>
    public static class SuccessControllerBaseExtensions
    {
        /// <summary>
        /// Creates an <see cref="NonAuthoritativeInformationResult"/> object that produces an Non-Authoritative Information (203) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="NonAuthoritativeInformationResult"/> for the response.</returns>
        public static NonAuthoritativeInformationResult NonAuthoritativeInformation(this ControllerBase controller)
            => new NonAuthoritativeInformationResult();

        /// <summary>
        /// Creates an <see cref="ResetContentResult"/> object that produces an Reset Content (205) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="ResetContentResult"/> for the response.</returns>
        public static ResetContentResult ResetContent(this ControllerBase controller)
            => new ResetContentResult();

        /// <summary>
        /// Creates a <see cref="PartialContentResult"/> object that produces a Partial Content (206) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="PartialContentResult"/> for the response.</returns>
        public static PartialContentResult PartialContent(this ControllerBase controller)
            => new PartialContentResult();

        /// <summary>
        /// Creates a <see cref="PartialContentObjectResult"/> object that produces a Partial Content (206) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="value">The data to be returned.</param>
        /// <returns>The created <see cref="PartialContentObjectResult"/> for the response.</returns>
        public static PartialContentObjectResult PartialContent(this ControllerBase controller, object value)
            => new PartialContentObjectResult(value);
    }
}
