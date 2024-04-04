using Food_At_Home.Models;

namespace Food_At_Home.Contracts
{
    public interface IProfileService
    {
        Task<ProfileViewModel> MyProfile(Guid userId, bool IsRestaurant);

        Task Edit(Guid userId, EditProfileModel model);
    }
}
