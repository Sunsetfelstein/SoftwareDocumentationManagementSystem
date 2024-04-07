using SoftwareDocumentationManagementSystem.Core.Models;
using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Http;

namespace SoftwareDocumentationManagementSystem.BL;

public class ImageService
{
    public Result<Image> CreateImage(IFormFile formFile, Guid softwareId, Software software, Guid authorId, User author, string description)
    {
        try
        {
            byte[] imageData = null;
            
            using(var binaryReader = new BinaryReader(formFile.OpenReadStream()))
            {
                imageData = binaryReader.ReadBytes((int)formFile.Length);
            }

            var imageResult = Image.Create(Guid.NewGuid(), softwareId, software, authorId, author, description,
                imageData);

            return imageResult;
        }
        catch (Exception exception)
        {
            return Result.Failure<Image>(exception.Message);
        }
    }
}