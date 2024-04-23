using System.Net;

namespace Falzoni.Presentation.Administrator.Models.Common
{
    public class StatusCodeModel
    {
        public virtual HttpStatusCode Status { get; set; }

        public string Message { get; set; }
    }
}