namespace AspNetCore.Mvc.HttpActionResults.Redirection.Test
{
    using System;

    using Microsoft.AspNetCore.Mvc;

    using Xunit;

    public class RedirectionControllerBaseExtensionsTest
    {
        [Fact]
        public void MultipleChoicesShouldReturnMultipleChoicesResult()
        {
            var controller = new HomeController();

            var result = controller.TestMultipleChoices();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<MultipleChoicesResult>(result);
        }

        [Fact]
        public void MultipleChoicesShouldReturnMultipleChoicesObjectResult()
        {
            var controller = new HomeController();
            var sampleValue = "Hello world!";

            var result = controller.TestMultipleChoices(sampleValue);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<MultipleChoicesObjectResult>(result);
        }

        [Fact]
        public void SeeOtherShouldReturnSeeOtherResult()
        {
            var controller = new HomeController();

            var result = controller.TestSeeOther();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<SeeOtherResult>(result);
        }

        [Fact]
        public void SeeOtherShouldReturnSeeOtherObjectResult()
        {
            var controller = new HomeController();
            var sampleValue = "Hello world!";

            var result = controller.TestSeeOther(sampleValue);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<SeeOtherObjectResult>(result);
        }

        [Fact]
        public void NotModifiedShouldReturnNotModifiedResult()
        {
            var controller = new HomeController();

            var result = controller.TestNotModified();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<NotModifiedResult>(result);
        }

        [Fact]
        public void UseProxShouldReturnUseProxResult()
        {
            var controller = new HomeController();
            var sampleValue = "fakeProxy";

            var result = controller.TestUseProxy(sampleValue);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<UseProxyResult>(result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("        ")]
        public void UseProxShouldThrowExceptionIfInvalidProxyIsGiven(string proxyValue)
        {
            var controller = new HomeController();

            Assert.Throws<ArgumentOutOfRangeException>(() => controller.TestUseProxy(proxyValue));
        }

        [Fact]
        public void TemporaryRedirectShouldTemporaryRedirectResult()
        {
            var controller = new HomeController();
            var sampleUri = "fakeUri";

            var result = controller.TestTemporaryRedirect(sampleUri);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<TemporaryRedirectResult>(result);
        }

        [Fact]
        public void TemporaryRedirectShouldTemporaryRedirectObjectResult()
        {
            var controller = new HomeController();
            var sampleUri = "fakeUri";
            var sampleValue = "HelloWorld";

            var result = controller.TestTemporaryRedirect(sampleValue, sampleUri);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<TemporaryRedirectObjectResult>(result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("        ")]
        public void TemporaryRedirectThrowExceptionIfInvalidProxyIsGiven(string proxyValue)
        {
            var controller = new HomeController();
            var sampleValue = "HelloWorld!";

            Assert.Throws<ArgumentOutOfRangeException>(() => controller.TemporaryRedirect(proxyValue));

            Assert.Throws<ArgumentOutOfRangeException>(() => controller.TemporaryRedirect(sampleValue, proxyValue));
        }

        private class HomeController : ControllerBase
        {
            public IActionResult TestMultipleChoices()
            {
                return this.MultipleChoices();
            }

            public IActionResult TestMultipleChoices(object value)
            {
                return this.MultipleChoices(value);
            }

            public IActionResult TestSeeOther()
            {
                return this.SeeOther();
            }

            public IActionResult TestSeeOther(object value)
            {
                return this.SeeOther(value);
            }

            public IActionResult TestNotModified()
            {
                return this.NotModified();
            }

            public IActionResult TestUseProxy(string proxyUri)
            {
                return this.UseProxy(proxyUri);
            }

            public IActionResult TestTemporaryRedirect(string temporaryUri)
            {
                return this.TemporaryRedirect(temporaryUri);
            }

            public IActionResult TestTemporaryRedirect(object value, string temporaryUri)
            {
                return this.TemporaryRedirect(value, temporaryUri);
            }
        }
    }
}
