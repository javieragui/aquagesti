using AquaGesti.Modules.Customers.Domain.Customers;

namespace AquaGesti.Modules.Customers.Application.Customers.CreateCustomers
{
    public sealed class CreateCustomerCommandHandler
    {
        private readonly ICustomerRepository _customerRepository;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Guid> Handle(CreateCustomerCommand command, CancellationToken cancellationToken = default)
        {
            var customer = new Customer(Guid.NewGuid(), command.Name, command.Email);

            await _customerRepository.AddAsync(customer, cancellationToken);

            return customer.Id;
        }
    }
}
