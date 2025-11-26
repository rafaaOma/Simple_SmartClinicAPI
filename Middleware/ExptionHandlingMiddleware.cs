using System.Net;
using System.Text.Json;

namespace SmartClinicAPI.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;//Next middleware in the pipline

        public ExceptionHandlingMiddleware(RequestDelegate next)//passing next middlieware
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)//handling the exception from next middleware
        {
            try
            {
                await _next(context); //go to next middleware in pipline
            }
            catch (Exception ex) //catch any expiton thron
            {
               
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError; 
                context.Response.ContentType = "application/json";//set response type json

                var errorResponse = new
                {
                    Message = "Something went wrong!",
                    Error = ex.Message
                };

                await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));//convert to json response with error message
            }
        }
    }
}