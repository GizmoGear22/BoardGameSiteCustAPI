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
        private const string apiHeader = "X-api-key";

		public ApiMiddleware(RequestDelegate next, IConfiguration config)
		{
			_next = next;
			_config = config;
		}

		public async Task InvokeAsync(HttpContext context)
		{

		}

	}


}
