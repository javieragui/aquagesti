using AquaGesti.SharedKernel.Domain;

namespace AquaGesti.Modules.Customers.Domain.Customers
{
    public sealed class Customer : AggregateRoot<Guid>
    {
        public string Name { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;

        private Customer()
        {
            Name = string.Empty;
            Email = string.Empty;
        }

        public Customer(Guid id, string name, string email) : base(id)
        {
            SetName(name);
            SetEmail(email);
        }

        public void Update(string name, string email)
        {
            SetName(name);
            SetEmail(email);
        }

        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Customer name cannot be empty.", nameof(name));

            Name = name.Trim();
        }

        private void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Customer email cannot be empty.", nameof(email));

            Email = email.Trim();
        }
    }
}
