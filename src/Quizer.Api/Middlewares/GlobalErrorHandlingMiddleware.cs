using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Quizer.Core.Exception;
using Quizer.Models.Common;
using System.Net;
using System.Text.Json;

namespace Quizer.Api.Middlewares
{
    internal class GlobalErrorHandlingMiddleware
    {
        private readonly RequestDelegate next;

        public GlobalErrorHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }


        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                ApiResponse? response = null;

                switch (ex)
                {
                    case NotFoundException:
                        response = ApiResponse.Fail(ex.Message, HttpStatusCode.NotFound);
                        break;

                    case UnhandledException:
                        break;

                    case BadRequestException:
                        response = ApiResponse.Fail(ex.Message, HttpStatusCode.BadRequest);
                        break;

                    default:

                        response = ApiResponse.Fail("Xeta bas verdi! Yeniden yoxlayin!", HttpStatusCode.NotFound);
                        break;
                }

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)response.StatusCode;
                await context.Response.WriteAsync(JsonConvert.SerializeObject(response, new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new CamelCaseNamingStrategy(),
                    },
                    NullValueHandling = NullValueHandling.Ignore,
                }));


            }


        }
    }

    internal static class GlobalErrorHandlingMiddlewareExtension
    {
        internal static IApplicationBuilder AddGlobalErrorHandling(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<GlobalErrorHandlingMiddleware>();

            return builder;
        }
    }
}
