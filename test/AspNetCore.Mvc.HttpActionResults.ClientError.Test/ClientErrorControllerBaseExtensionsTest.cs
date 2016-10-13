namespace AspNetCore.Mvc.HttpActionResults.ClientError.Test
{
    using Microsoft.AspNetCore.Mvc;
    using Xunit;

    public class ClientErrorControllerBaseExtensionsTest
    {
        [Fact]
        public void PaymentRequiredShouldReturnPaymentRequiredResult()
        {
            var controller = new HomeController();

            var result = controller.TestPaymentRequiredResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<PaymentRequiredResult>(result);
        }

        [Fact]
        public void GoneShouldReturnGoneResult()
        {
            var controller = new HomeController();

            var result = controller.TestGoneResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<GoneResult>(result);
        }

        [Fact]
        public void NotAcceptableShouldReturnNotAcceptableResult()
        {
            var controller = new HomeController();

            var result = controller.NotAcceptable();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<NotAcceptableResult>(result);
        }

        [Fact]
        public void NotAcceptableShouldReturnNotAcceptableObjectResult()
        {
            var controller = new HomeController();
            const string value = "I'm so fake";

            var result = controller.TestNotAcceptableObjectResult(value);

            Assert.NotNull(result);
            Assert.IsAssignableFrom<NotAcceptableObjectResult>(result);
            var actionResult = (NotAcceptableObjectResult)result;
            Assert.Equal(actionResult.Value, value);
        }

        [Fact]
        public void LengthRequiredShouldReturnLengthRequiredResult()
        {
            var controller = new HomeController();

            var result = controller.TestLengthRequiredResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<LengthRequiredResult>(result);
        }

        [Fact]
        public void UnsupportedMediaTypeShouldReturnUnsupportedMediaTypeResult()
        {
            var controller = new HomeController();

            var result = controller.TestUnsupportedMediaTypeResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<UnsupportedMediaTypeResult>(result);
        }

        [Fact]
        public void RequestTimeoutShouldReturnRequestTimeoutResult()
        {
            var controller = new HomeController();

            var result = controller.TestRequestTimeoutResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<RequestTimeoutResult>(result);
        }

        [Fact]
        public void ImATeapotShouldReturnImATeapotResult()
        {
            var controller = new HomeController();

            var result = controller.TestImATeapotResult();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<ImATeapotResult>(result);
        }

        private class HomeController : ControllerBase
        {
            public IActionResult TestPaymentRequiredResult()
            {
                return this.PaymentRequired();
            }

            public IActionResult TestGoneResult()
            {
                return this.Gone();
            }

            public IActionResult TestNotAcceptableResult()
            {
                return this.NotAcceptable();
            }

            public IActionResult TestNotAcceptableObjectResult(object data)
            {
                return this.NotAcceptable(data);
            }

            public IActionResult TestLengthRequiredResult()
            {
                return this.LengthRequired();
            }

            public IActionResult TestUnsupportedMediaTypeResult()
            {
                return this.UnsupportedMediaType();
            }

            public IActionResult TestRequestTimeoutResult()
            {
                return this.RequestTimeout();
            }

            public IActionResult TestImATeapotResult()
            {
                return this.ImATeapot();
            }
        }
    }
}
