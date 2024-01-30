namespace BarangayQR.API.Model
{
    public class CredentialDto
    {
        public Guid CredentialID { get; set; }
        public string? CredentialNumber { get; set; }
        public string? CredentialName { get; set; }
        public string? Description { get; set; }
        public int? CredentialType { get; set; }
        public string? CredentialTypeName { get; set; }
        public string? FileName { get; set; }
        public string? Url { get; set; }
        public string? CredentialData { get; set; }

        public Image? Image { get; set; }
    }

    public class Image
    {
        public Image(string data, string fileName)
        {
            if (data == null || data.Length == 0)
            {
                throw new ArgumentException("Image data cannot be null or empty.");
            }

            Data = data;
            FileName = fileName;
        }

        public Image(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("URL must be provided.");
            }

            Url = url;
        }

        public string? Data { get; set; } // This holds the image binary data.
        public string? FileName { get; set; } // The name of the file.
        public string? Url { get; set; } // The URL where the image can be accessed.
    }
}
