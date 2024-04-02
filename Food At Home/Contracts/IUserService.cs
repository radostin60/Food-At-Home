using Food_At_Home.Models;

namespace Food_At_Home.Contracts
{
    public interface IUserService
    {
        Task<bool> ExistsByEmail(string email);

        Task<bool> ExistsByPhone(string phone);

        Task<bool> ExistsById(Guid userId);

        Task DeleteUser(Guid userId);

        Task<UserModel> GetUserByIdAsync(Guid userId);

        Task<UserModel?> GetAdmin();

        Task<List<UserModel>> GetAllUsers();
    }
}
