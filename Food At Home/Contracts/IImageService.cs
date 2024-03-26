using Food_At_Home.Data.Models;

namespace Food_At_Home.Contracts
{
    public interface IImageService
    {
        Task<string> UploadImage(IFormFile imageFile, string nameFolder, Dish dish);

        Task<string> UploadImage(IFormFile imageFile, string nameFolder, User user);
    }
}
