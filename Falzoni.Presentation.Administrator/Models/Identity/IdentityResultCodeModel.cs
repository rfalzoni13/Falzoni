using System.Collections.Generic;

namespace Falzoni.Presentation.Administrator.Models.Identity
{
    public class IdentityResultCodeModel
    {
        public bool Succeeded { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}