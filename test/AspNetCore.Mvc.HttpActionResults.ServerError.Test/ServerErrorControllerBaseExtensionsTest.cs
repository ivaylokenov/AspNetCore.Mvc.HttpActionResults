namespace AspNetCore.Mvc.HttpActionResults.ServerError.Test
{
    using Microsoft.AspNetCore.Mvc;
    using Xunit;

    public class ServerErrorControllerBaseExtensionsTest
    {
        [Fact]
        public void BadGetawayShouldReturnBadGetawayResult()
        {
            var controller = new HomeController();

            var result = controller.TestBadGetawayResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<BadGetawayResult>(result);
        }

        private class HomeController : ControllerBase
        {
            public IActionResult TestBadGetawayResult()
            {
                return this.BadGetaway();
            }
        }
    }
}
