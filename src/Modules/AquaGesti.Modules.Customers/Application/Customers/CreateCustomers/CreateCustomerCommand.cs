namespace AquaGesti.Modules.Customers.Application.Customers.CreateCustomers
{
    public sealed class CreateCustomerCommand
    {
        public string Name { get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;
    }
}
