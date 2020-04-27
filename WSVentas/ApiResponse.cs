using Newtonsoft.Json;

namespace WSVentas
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public bool Fatal { get; set; }
        public object Result { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; }

        public ApiResponse() : this(true, "") { }

        public ApiResponse(bool success, string message = null)
        {
            this.Success = success;
            this.Fatal = false;
            Message = message;
        }

        public ApiResponse(string message)
        {
            this.Success = false;
            this.Fatal = false;
            Message = message ?? GetDefaultMessageForStatusCode(500);
        }

        public ApiResponse(object result) : this(true, "")
        {
            Result = result;
        }

        private static string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                404 => "Resource not found",
                500 => "An unhandled error occurred",
                _ => null,
            };
        }
    }
}
