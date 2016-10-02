namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// Class containing informational HTTP response extensions methods for <see cref="ControllerBase"/>. 
    /// </summary>
    public static class InformationalControllerBaseExtensions
    {
        /// <summary>
        /// Creates a <see cref="ContinueResult"/> object that produces a Continue (100) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="ContinueResult"/> for the response.</returns>
        public static ContinueResult Continue(this ControllerBase controller)
            => new ContinueResult();
    }
}
