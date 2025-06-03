using System.ComponentModel.DataAnnotations;

namespace BabyCareProject.Infrastructure.Utilities
{
    public static  class Media
    {
        public static async Task<string> UploadAsync(IFormFile file)
        {
            var currentDirectory= Directory.GetCurrentDirectory();  
            var path=Path.Combine(currentDirectory, "wwwroot/images");
            if(!Directory.Exists(path)) 
                Directory.CreateDirectory(path);
            var extension=Path.GetExtension(file.FileName).ToLowerInvariant();
            if (extension != ".png" && extension != ".jpg" && extension != ".jpeg")
                throw new ValidationException("Dosya resim formatında olmalıdır");
            var imageName = String.Concat(Guid.NewGuid().ToString(), extension);
            var imagePath = Path.Combine(path, imageName);
            using var stream = new FileStream(imagePath, mode: FileMode.Create);
            await file.CopyToAsync(stream);
            return string.Concat("/images/", imageName);

        }
    }
}
