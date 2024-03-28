namespace Food_At_Home.Contracts
{
    public interface ICustomerService
    {
        Task Create(string userId);

        Task<string?> GetCustomerId(string userId);
    }
}
