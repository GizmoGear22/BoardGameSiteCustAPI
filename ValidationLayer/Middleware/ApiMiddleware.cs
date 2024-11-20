using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace ValidationLayer.Middleware
{
    public class ApiMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _config;
        private const string apiHeader = "X-Api-Key";

		public ApiMiddleware(RequestDelegate next, IConfiguration config)
		{
			_next = next;
			_config = config;
		}

		public async Task InvokeAsync(HttpContext context)
		{
			if (!context.Request.Headers.TryGetValue(apiHeader, out var value))
				{
					context.Response.StatusCode = 401;
					await context.Response.WriteAsync("Enter API Key");
				return;
				}

			var apiKey = _config.GetValue<string>("apiKey");

			if (!apiKey.Equals(value)) 
			{
				context.Response.StatusCode = 402;
				await context.Response.WriteAsync("Input correct API Key");
				return;
			}

			await _next(context);

		}

	}


}
