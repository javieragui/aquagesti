using AquaGesti.Modules.Customers.Domain.Customers;

namespace AquaGesti.Modules.Customers.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        //private readonly AppDbContext _context;

        //public CustomerRepository(AppDbContext context)
        //{
        //    _context = context;
        //}

        public Task AddAsync(Customer customer, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //await _context.Customers.AddAsync(customer, cancellationToken);
        }

        public Task<Customer?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            //return await _context.Customers.FindAsync(id, cancellationToken);
        }
    }
}
