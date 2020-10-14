using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using try8.Model;

namespace try8.Inferastructure
{
    public class LogMiddleware
    {
        private RequestDelegate nextDelegate;
        public LogMiddleware(RequestDelegate next)
        {
            next = nextDelegate;
        }
       LogModel logModel = new LogModel();
        List<LogModel> logModels = new List<LogModel>();
        public async Task Invoke(HttpContext httpContext)
        {
            await nextDelegate.Invoke(httpContext);
            if (httpContext.Response.StatusCode==404)
            {
              await httpContext.Response.WriteAsync("404 error", Encoding.UTF8);
                logModel.Massege = "404";
                logModels.Add(logModel);
            }
            if (httpContext.Response.StatusCode == 403)
            {
                await httpContext.Response.WriteAsync("403 error", Encoding.UTF8);
                logModel.Massege = "403";
                logModels.Add(logModel);
            }
            if (httpContext.Response.StatusCode == 500)
            {
                await httpContext.Response.WriteAsync("500 error", Encoding.UTF8);
                logModel.Massege = "500";
                logModels.Add(logModel);
            }
            if (httpContext.Response.StatusCode == 200)
            {
                await httpContext.Response.WriteAsync("200 status", Encoding.UTF8);
                logModel.Massege="200";
                logModels.Add(logModel);
            }
        }
    }
}
