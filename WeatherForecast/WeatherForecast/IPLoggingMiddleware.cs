namespace WeatherForecast
{
    using Microsoft.AspNetCore.Http;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Logging;

    public class IPLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<IPLoggingMiddleware> _logger;

        public IPLoggingMiddleware(RequestDelegate next, ILogger<IPLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Get the IP address of the incoming request
            var ipAddress = context.Connection.RemoteIpAddress;

            // Log or check the IP address (this is just a log example)
            _logger.LogInformation($"Incoming request from IP address: {ipAddress}");

            // You can also perform any checks on the IP address here
            // if you want to block certain IPs, etc.
            Console.WriteLine("SIGMASIGMASIGMASIGMA");
            Console.WriteLine("IP ADRESSE :OOOOO " + ipAddress);

            // Continue with the next middleware in the pipeline
            await _next(context);
        }
    }

}
