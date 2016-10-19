namespace AspNetCore.Mvc.HttpActionResults.ClientError.Test
{
    using System.Linq;

    using AspNetCore.Mvc.HttpActionResults.ClientError.Test.Common;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Net.Http.Headers;

    using Xunit;

    public class ProxyAuthenticationRequiredResultTests : BaseHttpResultTests
    {
        [Fact]
        public async void ProxyAuthenticationRequiredShouldSetStatusCodeCorrectly()
        {
            // Arrange
            const string fakeHeaderValue = @"Basic realm=""proxy.com""";

            var fakeContext = this.CreateFakeActionContext();
            var result = new ProxyAuthenticationRequiredResult(fakeHeaderValue);

            // Act
            await result.ExecuteResultAsync(fakeContext);

            // Assert
            Assert.Equal(StatusCodes.Status407ProxyAuthenticationRequired, fakeContext.HttpContext.Response.StatusCode);
        }

        [Fact]
        public async void ProxyAuthenticationRequiredShouldSetHeaderCorrectly()
        {
            // Arrange
            const string fakeHeaderValue = @"Basic realm=""proxy.com""";

            var fakeContext = this.CreateFakeActionContext();
            var result = new ProxyAuthenticationRequiredResult(fakeHeaderValue);

            // Act
            await result.ExecuteResultAsync(fakeContext);

            // Assert
            var proxyAuthHeader =
                fakeContext.HttpContext.Response.Headers.FirstOrDefault(x => x.Key == HeaderNames.ProxyAuthenticate);

            Assert.NotNull(proxyAuthHeader);
            Assert.Equal(fakeHeaderValue, proxyAuthHeader.Value);
        }
    }
}
