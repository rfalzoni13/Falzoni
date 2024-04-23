using System;

namespace Falzoni.Presentation.Api.Models.Base
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}