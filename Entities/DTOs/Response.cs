namespace Entities.DTOs
{
    public class Response<T>
    {
        public T Data { get; set; } 
        public bool Success { get; set; } = true;
        public int StatusCode { get; set; } = (int)EnumStatusCode.Ok;
        public string Message { get; set; } = string.Empty;
    }
}
