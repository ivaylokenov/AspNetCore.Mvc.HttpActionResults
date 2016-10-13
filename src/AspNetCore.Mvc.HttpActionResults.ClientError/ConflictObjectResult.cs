namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// An <see cref="ObjectResult"/> that when executed performs content negotiation, formats the entity body, and
    /// will produce a <see cref="StatusCodes.Status409Conflict"/> response if negotiation and formatting succeed.
    /// </summary>
    public class ConflictObjectResult : ObjectResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConflictObjectResult"/> class.
        /// </summary>
        /// <param name="value">The content to format into the entity body.</param>
        public ConflictObjectResult(object value) 
            : base(value)
        {
            this.StatusCode = StatusCodes.Status409Conflict;
        }
    }
}
