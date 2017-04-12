namespace AspNetCore.Mvc.HttpActionResults.Success.Test
{
    using Microsoft.AspNetCore.Mvc;
    using Xunit;

    public class SuccessControllerBaseExtensionsTest
    {
        [Fact]
        public void AcceptedShouldReturnAcceptedResult()
        {
            var controller = new HomeController();

            var result = controller.TestAcceptedResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<AcceptedResult>(result);
        }

        [Fact]
        public void ResetContentShouldReturnResetContentResult()
        {
            var controller = new HomeController();

            var result = controller.TestResetContentResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<ResetContentResult>(result);
        }

        [Fact]
        public void NonAuthoritativeInformationShouldReturnNonAuthoritativeInformationResult()
        {
            var controller = new HomeController();

            var result = controller.TestNonAuthoritativeInformationResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<NonAuthoritativeInformationResult>(result);
        }

        [Fact]
        public void PartialContentShouldReturnPartialContentResult()
        {
            var controller = new HomeController();

            var result = controller.TestPartialContentResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<PartialContentResult>(result);
        }

        [Fact]
        public void PartialContentShouldReturnPartialContentObjectResultResult()
        {
            var controller = new HomeController();
            const string value = "I'm so fake";

            var result = controller.TestPartialContentResult(value);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<PartialContentObjectResult>(result);
        }

        private class HomeController : ControllerBase
        {
            public IActionResult TestAcceptedResult()
            {
                return this.Accepted();
            }

            public IActionResult TestResetContentResult()
            {
                return this.ResetContent();
            }

            public IActionResult TestNonAuthoritativeInformationResult()
            {
                return this.NonAuthoritativeInformation();
            }

            public IActionResult TestPartialContentResult()
            {
                return this.PartialContent();
            }

            public IActionResult TestPartialContentResult(object value)
            {
                return this.PartialContent(value);
            }
        }
    }
}