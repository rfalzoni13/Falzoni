using System.Collections.Generic;

namespace Falzoni.Domain.DTO.Identity
{
    public class IdentityResultCodeDTO
    {
        public bool Succeeded { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
