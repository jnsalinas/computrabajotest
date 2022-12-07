using System;
using ComputrabajoTest.Entities.MP.Base;
using ComputrabajoTest.Entities.MP.Enum;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace ComputrabajoTest.Api.Helpers
{
    public static class CustomException
    {
        /// <summary>
        /// middleware for manger all exceptions 
        /// </summary>
        /// <param name="app"></param>
        public static void ConfigureCustomExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        IConfiguration configuration = context.RequestServices.GetService(typeof(IConfiguration)) as IConfiguration;

                        context.Response.StatusCode = (int)HttpStatusCode.OK;

                        await context.Response.WriteAsync(
                            Newtonsoft.Json.JsonConvert.SerializeObject(new BaseOut()
                            {
                                Result = Result.GenericError,
                                Exception = contextFeature.Error.Message + " trace " + contextFeature.Error.StackTrace,
                                Message = "Internal Server Error."
                            }));
                    }
                });
            });
        }
    }

}

