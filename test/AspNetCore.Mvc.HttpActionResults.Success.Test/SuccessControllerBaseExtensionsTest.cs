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
        }
    }
}