namespace AspNetCore.Mvc.HttpActionResults.ClientError.Test.Common
{
    using System;
    using System.Buffers;
    using System.IO;

    using AspNetCore.Mvc.HttpActionResults.ClientError.Test.Common.Logging;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Abstractions;
    using Microsoft.AspNetCore.Mvc.Formatters;
    using Microsoft.AspNetCore.Mvc.Internal;
    using Microsoft.AspNetCore.Routing;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    using Newtonsoft.Json;

    public abstract class BaseHttpResultTests
    {
        // TODO: Extract to a base class for all unit testing projects
        protected ActionContext CreateFakeActionContext()
        {
            var httpContext = new DefaultHttpContext
            {
                RequestServices = this.CreateServices()
            };

            var stream = new MemoryStream();
            httpContext.Response.Body = stream;

            var context = new ActionContext(httpContext, new RouteData(), new ActionDescriptor());

            return context;
        }

        // TODO: Extract to a base class for all unit testing projects
        protected IServiceProvider CreateServices()
        {
            var options = new OptionsManager<MvcOptions>(new IConfigureOptions<MvcOptions>[] { });
            options.Value.OutputFormatters.Add(new StringOutputFormatter());
            options.Value.OutputFormatters.Add(new JsonOutputFormatter(
                new JsonSerializerSettings(),
                ArrayPool<char>.Shared));

            var services = new ServiceCollection();
            services.AddSingleton<ILoggerFactory>(FakeLoggerFactory.Instance);
            services.AddSingleton(new ObjectResultExecutor(
                options,
                new TestHttpResponseStreamWriterFactory(),
                FakeLoggerFactory.Instance));

            return services.BuildServiceProvider();
        }
    }
}
