namespace SmartClinicAPI.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next; // Next middleware in the pipeline
        public RequestLoggingMiddleware(RequestDelegate next) //passing the next middleware
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context) //processing the HTTP request
        {
            Console.WriteLine($"[Request] {context.Request.Method} {context.Request.Path}");//print request mwthod and path at console
            await _next(context);//calling the next middleware in the pipline
            Console.WriteLine($"[Response] {context.Response.StatusCode}");//print response status code at console
        }
    }
}