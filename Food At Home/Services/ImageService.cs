using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using Food_At_Home.Contracts;
using Food_At_Home.Data.Models;
using Food_At_Home.Data;

namespace Food_At_Home.Services
{
    public class ImageService:IImageService
    {
        private readonly Cloudinary cloudinary;
        private readonly FoodDbContext context;

        public ImageService(
            Cloudinary cloudinary)
        {
            this.cloudinary = cloudinary;
        }
        public async Task<string> UploadImage(IFormFile imageFile, string nameFolder, Dish dish)
        {
            using var stream = imageFile.OpenReadStream();

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(dish.Id.ToString(), stream),
                Folder = nameFolder
            };

            var uploadResult = await cloudinary.UploadAsync(uploadParams);

            if (uploadResult.Error != null)
            {
                throw new InvalidOperationException(uploadResult.Error.Message);
            }

            dish.ImageUrl = uploadResult.Url.ToString();

            return dish.ImageUrl;
        }

        public async Task<string> UploadImage(IFormFile imageFile, string nameFolder, User user)
        {

            using var stream = imageFile.OpenReadStream();

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(user.Id.ToString(), stream),
                Folder = nameFolder
            };

            var uploadResult = await cloudinary.UploadAsync(uploadParams);

            if (uploadResult.Error != null)
            {
                throw new InvalidOperationException(uploadResult.Error.Message);
            }

            user.ImageUrl = uploadResult.Url.ToString();

            this.context.Update(user);

            await context.SaveChangesAsync();

            return user.ImageUrl;
        }
    }
}
