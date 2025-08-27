namespace Ecommerce.API.Helper
{
    public class ResponseAPI
    {
        public ResponseAPI(int statusCode , string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetMessageFromStatusCode(StatusCode);
        }

        private string GetMessageFromStatusCode(int statusCode)
        {
            return statusCode switch
            {
                200 => "Success",
                400 => "Bad Request",
                401 => "UnAuthorized",
                404 => "Not Found",
                500 => "Internal Server Error",
                _ => "Unknown Status"
            };
        }
        public int StatusCode { get; set; }
        public string? Message { get; set; }
    }
}
