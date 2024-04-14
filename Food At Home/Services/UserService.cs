using Food_At_Home.Contracts;
using Food_At_Home.Data;
using Food_At_Home.Data.Models;
using Food_At_Home.Models;
using Microsoft.EntityFrameworkCore;

namespace Food_At_Home.Services
{
    public class UserService: IUserService
    {
        private readonly FoodDbContext context;

        public UserService(FoodDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> ExistsByEmail(string email)
        {
            var user = await context.Users
                .FirstOrDefaultAsync(u => u.Email == email );

            return user != null;
        }

        public async Task<bool> ExistsByPhone(string phone)
        {
            var user = await context.Users
                .FirstOrDefaultAsync(u => u.PhoneNumber == phone);

            return user != null;
        }

        public async Task<bool> ExistsById(Guid userId)
        {
            var userExists = await context.Users
                .AnyAsync(u => u.Id == userId);

            return userExists;
        }

        public async Task DeleteUser(Guid userId)
        {
            var user = await context.Users
                .FirstAsync(u => u.Id == userId);

            context.Users.Remove(user);
            await context.SaveChangesAsync();
        }

        public async Task<UserModel?> GetAdmin()
        {
            var admin = await context.Users
                .Where(u => u.Id == Guid.Parse("1e1fd1db-4ee5-4933-a51a-ead302e6db41"))
                .Select(u => new UserModel()
                {
                    Id = u.Id,
                    Name = u.Name,
                    Email = u.Email,
                    PhoneNumber = u.PhoneNumber,
                    Address = u.Address,
                    City = u.City,
                    ProfilePictureUrl = u.ImageUrl,
                })
                .FirstOrDefaultAsync();

            return admin;

        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            var users = await context.Users
                .Select(u => new UserModel()
                {
                    Id = u.Id,
                    Address = u.Address,
                    Email = u.Email,
                    Name = u.Name,
                    City = u.City,
                    ProfilePictureUrl = u.ImageUrl,
                })
                .ToListAsync();

            return users;
        }

        public async Task<UserModel> GetUserByIdAsync(Guid userId)
        {
            var user = await context.Users.FirstAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new NullReferenceException("This user does not exists");
            }

            var userModel = new UserModel()
            {
                Id = userId,
                Name = user.Name,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                City = user.City,
                ProfilePictureUrl = user.ImageUrl,

            };

            return userModel;
        }
    }
}
