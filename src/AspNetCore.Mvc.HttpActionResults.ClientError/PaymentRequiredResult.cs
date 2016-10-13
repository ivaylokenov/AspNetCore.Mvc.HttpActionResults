namespace Microsoft.AspNetCore.Mvc
{
    using Http;

    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce an empty
    /// <see cref="StatusCodes.Status402PaymentRequired"/> response.
    /// </summary>
    public class PaymentRequiredResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequiredResult"/> class.
        /// </summary>
        public PaymentRequiredResult() 
            : base(StatusCodes.Status402PaymentRequired)
        {
        }
    }
}
