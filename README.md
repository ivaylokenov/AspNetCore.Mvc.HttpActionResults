<h1><img src="https://raw.githubusercontent.com/ivaylokenov/AspNetCore.Mvc.HttpActionResults/master/tools/logo.png" align="left" alt="AspNetCore.Mvc.HttpActionResults" width="100">&nbsp; AspNetCore.Mvc.HttpActionResults - HTTP <br />&nbsp; status code results for ASP.NET Core MVC<br />&nbsp;</h1>
====================================

AspNetCore.Mvc.HttpActionResults is a collection of HTTP status code action results and controller extension methods for [ASP.NET Core MVC](https://github.com/aspnet/Mvc). Implemented as per the [HTTP status code specifications](https://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html).

## Installation

You can install this library using NuGet into your project (or reference it directly in your `project.json` file). There is no need to add any namespace usings since the package uses the default ones to add extension methods.

    Install-Package AspNetCore.Mvc.HttpActionResults

This package will include all available action results and extension methods in your test project. If you prefer, you can be more specific by including only some of the packages.

### Action results packages:

 - `AspNetCore.Mvc.HttpActionResults.Informational` - Contains Informational (1xx) HTTP action results
 - `AspNetCore.Mvc.HttpActionResults.Success` - Contains Success (2xx) HTTP action results
 - `AspNetCore.Mvc.HttpActionResults.Redirection` - Contains Redirection (3xx) HTTP action results
 - `AspNetCore.Mvc.HttpActionResults.ClientError` - Contains Client Error (4xx) HTTP action results
 - `AspNetCore.Mvc.HttpActionResults.ServerError` - Contains Server Error (5xx) HTTP action results
 
### ControllerBase extension methods packages:

 - `AspNetCore.Mvc.HttpActionResults.Informational.Extensions` - Contains Informational (1xx) HTTP extension methods
 - `AspNetCore.Mvc.HttpActionResults.Success.Extensions` - Contains Success (2xx) HTTP extension methods
 - `AspNetCore.Mvc.HttpActionResults.Redirection.Extensions` - Contains Redirection (3xx) HTTP extension methods
 - `AspNetCore.Mvc.HttpActionResults.ClientError.Extensions` - Contains Client Error (4xx) HTTP extension methods
 - `AspNetCore.Mvc.HttpActionResults.ServerError.Extensions` - Contains Server Error (5xx) HTTP extension methods

## How to use

After the downloading is complete, you can use the provided action results and controller extension methods.

### Available action results:

```c#
// 100 Continue
ContinueResult

// 101 Switching Protocols
SwitchingProtocolsResult

// 202 Accepted
AcceptedResult
AcceptedObjectResult

// 303 See Other
SeeOtherResult
SeeOtherObjectResult

// 304 Not Modified
NotModifiedResult

// 405 Method Not Allowed
MethodNotAllowedResult

// 408 Request Timeout
RequestTimeoutResult

// 412 Precondition Failed
PreconditionFailedResult
PreconditionFailedObjectResult

// 501 Not Implemented
NotImplementedResult

// 502 Bad Gateway
BadGatewayResult

// 504 Gateway Timeout
GatewayTimeoutResult
```

### Available ControllerBase extension methods:

```c#
// returns 100 Continue
controller.Continue();

// returns 101 Switching Protocols
controller.SwitchingProtocols(upgradeValue);

// returns 202 Accepted
controller.Accepted();

// returns 202 Accepted with Location header
controller.Accepted(someUri);

// returns 202 Accepted with formatted value
controller.Accepted(someObject);

// returns 202 Accepted with Location header and formatted value
controller.Accepted(someUri, someObject);

// returns 303 See Other
controller.SeeOther();

// returns 303 See Other with Location header
controller.SeeOther(someUri);

// returns 303 See Other with formatted value
controller.SeeOther(someObject);

// returns 303 See Other with Location header and formatted value
controller.SeeOther(someUri, someObject);

// returns 304 Not Modified
controller.NotModified();

// returns 405 Method Not Allowed
controller.MethodNotAllowed();

// returns 408 Request Timeout
controller.RequestTimeout();

// returns 412 Precondition Failed
controller.PreconditionFailed();

// returns 412 Precondition Failed with formatted value
controller.PreconditionFailed(someObject);

// returns 415 Unsupported Media Type
controller.UnsupportedMediaType();

// returns 501 Not Implemented
controller.NotImplemented();

// returns 502 Bad Gateway
controller.BadGateway();

// returns 502 Gateway Timeout
controller.GatewayTimeout();
```

## License

Code by Ivaylo Kenov. Copyright 2016 Ivaylo Kenov.

This package has MIT license. Refer to the [LICENSE](https://github.com/ivaylokenov/AspNetCore.Mvc.HttpActionResults/blob/master/LICENSE) for detailed information.

## Any questions, comments or additions?

If you have a feature request or bug report, leave an issue on the [issues page](https://github.com/ivaylokenov/AspNetCore.Mvc.HttpActionResults/issues) or send a [pull request](https://github.com/ivaylokenov/AspNetCore.Mvc.HttpActionResults/pulls). For general questions and comments, use the [StackOverflow](http://stackoverflow.com/) forum.
