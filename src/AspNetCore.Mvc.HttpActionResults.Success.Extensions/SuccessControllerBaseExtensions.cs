namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// Class containing success HTTP response extensions methods for <see cref="ControllerBase"/>. 
    /// </summary>
    public static class SuccessControllerBaseExtensions
    {
        /// <summary>
        /// Creates an <see cref="ResetContentResult"/> object that produces an Accepted (205) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="ResetContentResult"/> for the response.</returns>
        public static ResetContentResult ResetContent(this ControllerBase controller)
            => new ResetContentResult();
    }
}
