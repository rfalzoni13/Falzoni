using System;

namespace Falzoni.Domain.DTO.Base
{
    public class BaseDTO
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
