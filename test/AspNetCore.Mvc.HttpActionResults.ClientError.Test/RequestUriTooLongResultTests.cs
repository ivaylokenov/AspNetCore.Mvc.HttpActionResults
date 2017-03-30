namespace AspNetCore.Mvc.HttpActionResults.ClientError.Test
{
    using AspNetCore.Mvc.HttpActionResults.Test;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using Xunit;

    public class RequestUriTooLongResultTests : BaseHttpResultTests
    {
        [Fact]
        public async void RequestUriTooLongResultShouldSetStatusCodeCorrectly()
        {
            // Arrange
            var fakeContext = this.CreateFakeActionContext();
            var result = new RequestUriTooLongResult();

            // Act
            await result.ExecuteResultAsync(fakeContext);

            // Assert
            Assert.Equal(StatusCodes.Status414RequestUriTooLong, fakeContext.HttpContext.Response.StatusCode);
        }
    }
}
