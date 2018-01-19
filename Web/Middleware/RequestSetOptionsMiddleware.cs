using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace Web.Middleware
{
    public class RequestSetOptionsMiddleware
    {
        private readonly RequestDelegate _next;
        private string _injectedOptions;

        public RequestSetOptionsMiddleware(RequestDelegate next)
        {
            _next = next;
            _injectedOptions = "";
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine("RequestSetOptionsMiddleware.Invoke");
            var option = httpContext.Request.Query["option"];
            if (!string.IsNullOrWhiteSpace(option))
            {
                _injectedOptions = WebUtility.HtmlEncode(option);
            }

            await _next(httpContext);
        }
    }

}
