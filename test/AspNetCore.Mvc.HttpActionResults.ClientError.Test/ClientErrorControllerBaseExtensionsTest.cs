namespace AspNetCore.Mvc.HttpActionResults.ClientError.Test
{
    using Microsoft.AspNetCore.Mvc;
    using Xunit;

    public class ClientErrorControllerBaseExtensionsTest
    {
        [Fact]
        public void AcceptedShouldReturnAcceptedResult()
        {
            var controller = new HomeController();

            var result = controller.TestUnsupportedMediaTypeResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<UnsupportedMediaTypeResult>(result);
        }

        private class HomeController : ControllerBase
        {
            public IActionResult TestUnsupportedMediaTypeResult()
            {
                return this.UnsupportedMediaType();
            }
        }
    }
}
