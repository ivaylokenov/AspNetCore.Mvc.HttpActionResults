namespace Microsoft.AspNetCore.Mvc
{
    using Extensions.Primitives;
    using Net.Http.Headers;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// A <see cref="SwitchingProtocolsResult"/> that when executed will 
    /// produce a Switching Protocols (101) response.
    /// </summary>
    public class SwitchingProtocolsResult : StatusCodeResult
    {
        private string upgradeTo;

        /// <summary>
        /// Initializes a new instance of the <see cref="SwitchingProtocolsResult"/> class.
        /// </summary>
        /// <param name="upgradeTo">Value to put in the response "Upgrade" header.</param>
        public SwitchingProtocolsResult(string upgradeTo)
            : base(101)
        {
            if (string.IsNullOrWhiteSpace(upgradeTo))
            {
                throw new ArgumentNullException(nameof(upgradeTo));
            }

            this.UpgradeTo = upgradeTo;
        }

        /// <summary>
        /// Gets or sets the value to put in the response  <see cref="HeaderNames.Upgrade"/> header.
        /// </summary>
        public string UpgradeTo
        {
            get
            {
                return this.upgradeTo;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }

                this.upgradeTo = value;
            }
        }

        /// <inheritdoc />
        public override Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.Headers.Add(HeaderNames.Connection, "upgrade");
            context.HttpContext.Response.Headers.Add(HeaderNames.Upgrade, new StringValues(this.UpgradeTo));

            return base.ExecuteResultAsync(context);
        }
    }
}
