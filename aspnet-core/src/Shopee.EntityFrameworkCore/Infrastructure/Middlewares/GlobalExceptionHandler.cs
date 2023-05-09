using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Shopee.Infrastructure.Middlewares
{
    public class GlobalExceptionHandler : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception error)
            {
                context.Response.ContentType = "application/json";

                switch (error)
                {
                    case Exception e:
                        context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                        break;
                    default:
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                ProblemDetails problem = new()
                {
                    Status = context.Response.StatusCode,
                    Detail = error.Message
                };

                await context.Response.WriteAsync(JsonSerializer.Serialize(problem));

            }
        }
    }
}
