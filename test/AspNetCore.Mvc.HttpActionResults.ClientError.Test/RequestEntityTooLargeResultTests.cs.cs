namespace AspNetCore.Mvc.HttpActionResults.ClientError.Test
{
    using System.Linq;

    using AspNetCore.Mvc.HttpActionResults.Test;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Net.Http.Headers;

    using Xunit;

    public class RequestEntityTooLargeResultTests : BaseHttpResultTests
    {
        [Fact]
        public async void ProxyAuthenticationRequiredShouldSetStatusCodeCorrectly()
        {
            // Arrange
            const string fakeHeaderValue = "Fake header value";

            var fakeContext = this.CreateFakeActionContext();
            var result = new RequestEntityTooLargeResult(fakeHeaderValue);

            // Act
            await result.ExecuteResultAsync(fakeContext);

            // Assert
            Assert.Equal(StatusCodes.Status413RequestEntityTooLarge, fakeContext.HttpContext.Response.StatusCode);
        }

        [Fact]
        public async void ProxyAuthenticationRequiredShouldSetHeaderCorrectly()
        {
            // Arrange
            const string fakeHeaderValue = "Fake header value";

            var fakeContext = this.CreateFakeActionContext();
            var result = new RequestEntityTooLargeResult(fakeHeaderValue);

            // Act
            await result.ExecuteResultAsync(fakeContext);

            // Assert
            var proxyAuthHeader =
                fakeContext.HttpContext.Response.Headers.FirstOrDefault(x => x.Key == HeaderNames.RetryAfter);

            Assert.NotNull(proxyAuthHeader);
            Assert.Equal(fakeHeaderValue, proxyAuthHeader.Value);
        }

        [Fact]
        public async void ProxyAuthenticationRequiredShouldNotSendHeaderIfNoValueForRetryAfterIsGiven()
        {
            // Arrange
            var fakeContext = this.CreateFakeActionContext();
            var result = new RequestEntityTooLargeResult();

            // Act
            await result.ExecuteResultAsync(fakeContext);

            // Assert
            var requestHasHeaders =
                fakeContext.HttpContext.Response.Headers.Any();

            Assert.False(requestHasHeaders);
        }
    }
}
