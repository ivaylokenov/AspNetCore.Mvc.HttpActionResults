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

        /// <summary>
        /// Creates a <see cref="SwitchingProtocolsResult"/> object that produces a Switching Protocols (101) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="upgradeTo">The protocol to which the communication is upgraded.</param>
        /// <returns>The created <see cref="SwitchingProtocolsResult"/> for the response.</returns>
        public static SwitchingProtocolsResult SwitchingProtocols(this ControllerBase controller, string upgradeTo)
            => new SwitchingProtocolsResult(upgradeTo);
    }
}
