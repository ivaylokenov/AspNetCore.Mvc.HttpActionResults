namespace AspNetCore.Mvc.HttpActionResults.Success.Extensions.Test
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

        private class HomeController : ControllerBase
        {
            public IActionResult TestAcceptedResult()
            {
                return this.Accepted();
            }
        }
    }
}
