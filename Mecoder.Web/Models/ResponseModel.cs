using System.Net;

namespace Mecoder.Web.Models
{
    public class ResponseModel<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
