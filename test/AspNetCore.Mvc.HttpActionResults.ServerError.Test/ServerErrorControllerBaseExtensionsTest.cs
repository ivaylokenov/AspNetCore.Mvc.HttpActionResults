namespace AspNetCore.Mvc.HttpActionResults.ServerError.Test
{
    using Microsoft.AspNetCore.Mvc;
    using Xunit;

    public class ServerErrorControllerBaseExtensionsTest
    {
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
        public void ServiceUnavailableShouldReturnServiceUnavailableResult()
        {
            var controller = new HomeController();

            var result = controller.TestServiceUnavailableResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<ServiceUnavailableResult>(result);
        }

        [Fact]
        public void ServiceUnavailableShouldReturnServiceUnavailableResultWithLengthOfDelay()
        {
            var controller = new HomeController();

            var lengthOfDelay = "10";
            var result = controller.TestServiceUnavailableResultWithLengthOfDelay(lengthOfDelay);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<ServiceUnavailableResult>(result);
            var actionResult = (ServiceUnavailableResult)result;
            Assert.Equal(actionResult.LengthOfDelay, lengthOfDelay);
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
            public IActionResult TestNotImplementedResult()
            {
                return this.NotImplemented();
            }

            public IActionResult TestBadGatewayResult()
            {
                return this.BadGateway();
            }

            public IActionResult TestServiceUnavailableResult()
            {
                return this.ServiceUnavailable();
            }

            public IActionResult TestServiceUnavailableResultWithLengthOfDelay(string lengthOfDelay)
            {
                return this.ServiceUnavailable(lengthOfDelay);
            }

            public IActionResult TestGatewayTimeoutResult()
            {
                return this.GatewayTimeout();
            }
        }
    }
}
