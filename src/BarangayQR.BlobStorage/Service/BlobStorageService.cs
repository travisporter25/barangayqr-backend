//using Core.ValueObject;
//using Azure.Storage.Blobs;
//using Azure.Storage.Blobs.Models;
//using BlobStorage.Entities;
//using Microsoft.Extensions.Options;

//namespace BlobStorage.Service;

//public class BlobStorageService : Core.Services.IBlobStorageService
//{
//    private readonly BlobServiceClient _blobServiceClient;
//    private readonly string? _containerName;


//    public BlobStorageService(IOptions<Config> configuration)
//    {
//        _blobServiceClient = new BlobServiceClient(configuration.Value.ConnectionString);
//        _containerName = configuration.Value.ContainerName;
//    }

//    public BlobStorageService(Config config)
//    {
//        _blobServiceClient = new BlobServiceClient(config.ConnectionString);
//        _containerName = config.ContainerName;
//    }


//    public async Task<Image> GetByFileName(string fileName)
//    {
//        var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);

//        // Implement logic to retrieve image by file name from Azure Blob Storage
//        var blobClient = containerClient.GetBlobClient(fileName);

//        if (!await blobClient.ExistsAsync())
//        {
//            // Handle case when the image with the specified file name does not exist
//            throw new ArgumentException($"Image with file name '{fileName}' not found.");
//        }

//        return new Image(blobClient.Uri.ToString());
//    }


//    public async Task<Image> Upload(Image image)
//    {
//        if (image.Data is null)
//        {
//            throw new Exception("Image data is null");
//        }

//        if (string.IsNullOrWhiteSpace(image.FileName))
//        {
//            throw new Exception("Image file name is invalid");
//        }

//        var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
//        var blobClient = containerClient.GetBlobClient(image.FileName);

//        byte[] imageData = Convert.FromBase64String(image.Data);

//        using (var stream = new MemoryStream(imageData))
//        {
//            // Set the content type explicitly based on the image file extension
//            var contentType = GetContentType(image.FileName);

//            // Upload the image to Azure Blob Storage with the specified content type
//            await blobClient.UploadAsync(stream, new BlobUploadOptions
//            {
//                HttpHeaders = new BlobHttpHeaders { ContentType = contentType },
//            });

//        }

//        return new Image(blobClient.Uri.ToString());
//    }

//    private static string GetContentType(string fileName)
//    {
//        // Map file extensions to content types
//        return Path.GetExtension(fileName).ToLowerInvariant() switch
//        {
//            ".jpg" or ".jpeg" => "image/jpeg",
//            ".png" => "image/png",
//            // Add more cases as needed for other image formats
//            _ => "application/octet-stream",// Default to binary if unknown
//        };
//    }
//}
