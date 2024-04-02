namespace Food_At_Home.Contracts
{
    public interface ICustomerService
    {
        Task Create(Guid userId);

        Task<Guid?> GetCustomerId(Guid userId);
    }
}
