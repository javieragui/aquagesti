namespace AquaGesti.Modules.Customers.Domain.Customers
{
    public interface ICustomerRepository
    {
        Task AddAsync(Customer customer, CancellationToken cancellationToken = default);

        Task<Customer?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
