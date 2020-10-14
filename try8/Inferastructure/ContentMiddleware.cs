using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try8.Inferastructure
{
    public class ContentMiddleware
    {
        private RequestDelegate nextDelegate;
        public ContentMiddleware(RequestDelegate next)
        {
            next = nextDelegate;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Path.ToString().ToLower()=="/test")
            {
                await httpContext.Response.WriteAsync("test in url", Encoding.UTF8);
            }
            else
            {
                await nextDelegate.Invoke(httpContext);
            }
        }
    }
}
