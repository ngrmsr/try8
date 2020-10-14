using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try8.Inferastructure
{
    public class ErrorMiddleware
    {
        private RequestDelegate nextDelegate;
        public ErrorMiddleware(RequestDelegate next)
        {
            next = nextDelegate;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Headers["user-agent"].Any(a=>a.ToLower().Contains("edge")))
            {
                 httpContext.Response.StatusCode = 403;
            }
            else
            {
                await nextDelegate.Invoke(httpContext);
            }
        }
    }
}
