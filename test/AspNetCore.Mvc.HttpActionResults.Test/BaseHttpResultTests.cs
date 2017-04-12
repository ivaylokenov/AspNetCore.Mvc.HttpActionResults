namespace AspNetCore.Mvc.HttpActionResults.Test
{
    using System;
    using System.Buffers;
    using System.IO;

    using AspNetCore.Mvc.HttpActionResults.Test.Logging;

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
