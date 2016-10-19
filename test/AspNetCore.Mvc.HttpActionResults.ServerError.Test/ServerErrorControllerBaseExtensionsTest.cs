namespace AspNetCore.Mvc.HttpActionResults.ServerError.Test
{
	using Microsoft.AspNetCore.Mvc;
	using System;
	using Xunit;

	public class ServerErrorControllerBaseExtensionsTest
	{
		[Fact]
		public void InternalServerErrorShouldReturnInternalServerErrorResult()
		{
			var controller = new HomeController();

			var result = controller.TestInternalServerError();

			Assert.NotNull(result);
			Assert.IsAssignableFrom<InternalServerErrorResult>(result);
		}

		[Fact]
		public void InternalServerErrorShouldReturnExceptionResult()
		{
			var controller = new HomeController();

			var result = controller.TestExceptionResult(new Exception());

			Assert.NotNull(result);
			Assert.IsAssignableFrom<ExceptionResult>(result);
		}

		[Fact]
		public void InternalServerErrorShouldReturnExceptionResultWithErrors()
		{
			var controller = new HomeController();

			var result = controller.TestExceptionResult(new Exception(), true);

			Assert.NotNull(result);
			Assert.IsAssignableFrom<ExceptionResult>(result);
		}

		[Fact]
		public void InternalServerErrorNullShouldThrowArgumentNullException()
		{
			var controller = new HomeController();

			Assert.Throws<ArgumentNullException>(() => controller.TestExceptionResult(null));
		}

		[Fact]
		public void InternalServerErrorNullWithParameterShouldThrowArgumentNullException()
		{
			var controller = new HomeController();

			Assert.Throws<ArgumentNullException>(() => controller.TestExceptionResult(null, true));
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

		[Fact]
		public void HTTPVersionNotSupportedShouldReturnHTTPVersionNotSupportedResult()
		{
			var controller = new HomeController();
			var value = new object { };

			var result = controller.TestHTTPVersionNotSupportedResult(value);

			Assert.NotNull(result);
			Assert.IsAssignableFrom<HTTPVersionNotSupportedResult>(result);
			var actionResult = (HTTPVersionNotSupportedResult)result;
			Assert.Equal(actionResult.Value, value);
		}

		private class HomeController : ControllerBase
		{
			public IActionResult TestExceptionResult(Exception exception, bool includeErrorDetail)
			{
				return this.InternalServerError(exception, includeErrorDetail);
			}

			public IActionResult TestExceptionResult(Exception exception)
			{
				return this.InternalServerError(exception);
			}

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

			public IActionResult TestHTTPVersionNotSupportedResult(object value)
			{
				return this.HTTPVersionNotSupported(value);
			}
		}
	}
}
