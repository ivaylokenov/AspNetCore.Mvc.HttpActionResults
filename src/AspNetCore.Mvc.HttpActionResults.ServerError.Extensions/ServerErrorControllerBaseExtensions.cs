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
        /// Creates an <see cref="BadGetawayResult"/> object that produces an Bad Getaway (502) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="BadGetawayResult"/> for the response.</returns>
        public static BadGetawayResult BadGetaway(this ControllerBase controller)
            => new BadGetawayResult();
    }
}
