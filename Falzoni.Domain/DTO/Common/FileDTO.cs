using System.Drawing.Imaging;

namespace Falzoni.Domain.DTO.Common
{
    public class FileDTO
    {
        public string FileName { get; set; }

        public string Base64String { get; set; }

        public ImageFormat Format { get; set; }
    }
}
