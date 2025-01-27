namespace ManagementCabin
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ShabbatMiddleware> _logger;

        public ShabbatMiddleware(RequestDelegate next, ILogger<ShabbatMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var shabbat = DateTime.Today.DayOfWeek == DayOfWeek.Saturday;

            if (shabbat)
            {
                var responseMessage = new HttpResponseMessage
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Content = new StringContent(
                      "השירות אינו פעיל בשבת.",
                      System.Text.Encoding.UTF8,
                      "application/json")
                };

                await context.Response.WriteAsync(responseMessage.Content.ReadAsStringAsync().Result);
            }
            else
            {
                await _next(context);
            }
        }
    }
}
