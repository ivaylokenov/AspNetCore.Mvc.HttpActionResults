namespace AspNetCore.Mvc.HttpActionResults.ServerError.Test
{
    using Microsoft.AspNetCore.Mvc;
    using Xunit;

    public class ServerErrorControllerBaseExtensionsTest
    {
        [Fact]
        public void InternalServerErrorShouldReturnInternalServerErrorResult()
        {
            var controller = new HomeController();

            var result = controller.InternalServerError();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<InternalServerErrorResult>(result);
        }

        [Fact]
        public void NotImplementedShouldReturnNotImplementedResult()
        {
            var controller = new HomeController();

            var result = controller.TestNotImplementedResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<NotImplementedResult>(result);
        }

        [Fact]
        public void BadGatewayShouldReturnBadGatewayResult()
        {
            var controller = new HomeController();

            var result = controller.TestBadGatewayResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<BadGatewayResult>(result);
        }

        [Fact]
        public void GatewayTimeoutShouldReturnGatewayTimeoutResult()
        {
            var controller = new HomeController();

            var result = controller.TestGatewayTimeoutResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<GatewayTimeoutResult>(result);
        }

        private class HomeController : ControllerBase
        {
            public IActionResult TestInternalServerError()
            {
                return this.InternalServerError();
            }

            public IActionResult TestNotImplementedResult()
            {
                return this.NotImplemented();
            }

            public IActionResult TestBadGatewayResult()
            {
                return this.BadGateway();
            }

            public IActionResult TestGatewayTimeoutResult()
            {
                return this.GatewayTimeout();
            }
        }
    }
}
