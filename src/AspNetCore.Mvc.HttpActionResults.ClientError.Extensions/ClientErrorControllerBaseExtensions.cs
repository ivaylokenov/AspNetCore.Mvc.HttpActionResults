using Microsoft.Extensions.Primitives;
using Microsoft.Net.Http.Headers;

namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// Class containing client error HTTP response extensions methods for <see cref="ControllerBase"/>. 
    /// </summary>
    public static class ClientErrorControllerBaseExtensions
    {
        /// <summary>
        /// Creates a <see cref="PaymentRequiredResult"/> object that produces a Payment Required (402) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="PaymentRequiredResult"/> for the response.</returns>
        public static PaymentRequiredResult PaymentRequired(this ControllerBase controller)
            => new PaymentRequiredResult();

        /// <summary>
        /// Creates a <see cref="MethodNotAllowedResult"/> object that produces a Method Not Allowed (405) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="allowedMethods">Allowed HTTPS methods for this request.</param>
        /// <returns>The created <see cref="MethodNotAllowedResult"/> for the response.</returns>
        public static MethodNotAllowedResult MethodNotAllowed(this ControllerBase controller, string allowedMethods)
            => new MethodNotAllowedResult(allowedMethods);

        /// <summary>
        /// Creates a <see cref="MethodNotAllowedResult"/> object that produces a Method Not Allowed (405) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="allowedMethods">Allowed HTTPS methods for this request.</param>
        /// <returns>The created <see cref="MethodNotAllowedResult"/> for the response.</returns>
        public static MethodNotAllowedResult MethodNotAllowed(this ControllerBase controller, params string[] allowedMethods)
           => new MethodNotAllowedResult(new StringValues(allowedMethods));

        /// <summary>
        /// Creates a <see cref="PreconditionFailedResult"/> object that produces a Precondition Failed (412) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="PreconditionFailedResult"/> for the response.</returns>
        public static PreconditionFailedResult PreconditionFailed(this ControllerBase controller)
            => new PreconditionFailedResult();

        /// <summary>
        /// Creates a <see cref="GoneResult"/> object that produces a Gone (410) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="GoneResult"/> for the response.</returns>
        public static GoneResult Gone(this ControllerBase controller)
            => new GoneResult();

        /// <summary>
        /// Creates a <see cref="LengthRequiredResult"/> object that produces a Length Required (411) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="LengthRequiredResult"/> for the response.</returns>
        public static LengthRequiredResult LengthRequired(this ControllerBase controller)
            => new LengthRequiredResult();

        /// <summary>
        /// Creates a <see cref="PreconditionFailedObjectResult"/> object that produces a Precondition Failed (412) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="value">The precondition failed value to format in the entity body.</param>
        /// <returns></returns>
        public static PreconditionFailedObjectResult PreconditionFailed(this ControllerBase controller, object value)
            => new PreconditionFailedObjectResult(value);

        /// <summary>
        /// Creates a <see cref="RequestTimeoutResult"/> object that produces a Request Timeout (408) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="RequestTimeoutResult"/> for the response.</returns>
        public static RequestTimeoutResult RequestTimeout(this ControllerBase controller)
            => new RequestTimeoutResult();

        /// <summary>
        /// Creates an <see cref="UnsupportedMediaTypeResult"/> object that produces an Unsupported Media Type (415) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="UnsupportedMediaTypeResult"/> for the response.</returns>
        public static UnsupportedMediaTypeResult UnsupportedMediaType(this ControllerBase controller)
            => new UnsupportedMediaTypeResult();

        /// <summary>
        /// Creates an <see cref="ImATeapotResult"/> object that produces an Im a Teapot (418) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="ImATeapotResult"/> for the response.</returns>
        public static ImATeapotResult ImATeapot(this ControllerBase controller)
            => new ImATeapotResult();

        /// <summary>
        /// Creates an <see cref="RequestedRangeNotSatisfiableResult"/> object that produces an Requested Range Not Satisfiable (416) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="RequestedRangeNotSatisfiableResult"/> for the response.</returns>
        public static RequestedRangeNotSatisfiableResult RequestedRangeNotSatisfiable(this ControllerBase controller)
            => new RequestedRangeNotSatisfiableResult();

        /// <summary>
        /// Creates an <see cref="RequestedRangeNotSatisfiableResult"/> object that produces an Requested Range Not Satisfiable (416) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <param name="selectedResourceLength"> The current length of the selected resource</param>
        /// <returns>The created <see cref="RequestedRangeNotSatisfiableResult"/> for the response.</returns>
        public static RequestedRangeNotSatisfiableResult RequestedRangeNotSatisfiable(this ControllerBase controller, long? selectedResourceLength)
            => new RequestedRangeNotSatisfiableResult(selectedResourceLength);

        /// <summary>
        /// Creates an <see cref="ExpectationFailedResult"/> object that produces an Expectation Failed (417) response.
        /// </summary>
        /// <param name="controller">MVC controller instance.</param>
        /// <returns>The created <see cref="ExpectationFailedResult"/> for the response.</returns>
        public static ExpectationFailedResult ExpectationFailed(this ControllerBase controller)
            => new ExpectationFailedResult();
    }
}
