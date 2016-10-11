namespace Microsoft.AspNetCore.Mvc
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Net.Http.Headers;
    using Microsoft.Extensions.Primitives;

    /// <summary>
    /// A <see cref="SwitchingProtocolsResult"/> that when executed will 
    /// produce a Switching Protocols (101) response.
    /// </summary>
    public class SwitchingProtocolsResult : StatusCodeResult
    {
        private readonly string upgradeTo;

        /// <summary>
        /// Initializes a new instance of the <see cref="SwitchingProtocolsResult"/> class.
        /// </summary>
        /// <param name="upgradeTo">Value to put in the response "Upgrade" header.</param>
        public SwitchingProtocolsResult(string upgradeTo)
            : base(101)
        {
            this.upgradeTo = upgradeTo;
        }

        /// <inheritdoc />
        public override Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.Headers.Add(HeaderNames.Connection, "upgrade");
            context.HttpContext.Response.Headers.Add(HeaderNames.Upgrade, new StringValues(this.upgradeTo));

            return base.ExecuteResultAsync(context);
        }
    }
}
