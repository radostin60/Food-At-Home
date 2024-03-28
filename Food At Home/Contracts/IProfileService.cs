using Food_At_Home.Models;

namespace Food_At_Home.Contracts
{
    public interface IProfileService
    {
        Task<ProfileViewModel> MyProfile(string userId, bool IsRestaurant);

        Task Edit(string userId, EditProfileModel model);
    }
}
