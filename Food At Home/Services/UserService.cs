using Food_At_Home.Contracts;
using Food_At_Home.Data;

namespace Food_At_Home.Services
{
    public class UserService: IUserService
    {
        private readonly FoodDbContext context;

        public UserService(FoodDbContext context)
        {
            this.context = context;
        }


    }
}
