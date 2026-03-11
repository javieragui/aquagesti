using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaGesti.SharedKernel.Domain
{
    public abstract class ValueObject
    {
        protected abstract IEnumerable<object?> GetAtomicValues();

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType())
                return false;

            var other = (ValueObject)obj;

            return GetAtomicValues().SequenceEqual(other.GetAtomicValues());
        }

        public override int GetHashCode()
        {
            return GetAtomicValues()
                .Aggregate(0, (current, value) =>
                    HashCode.Combine(current, value));
        }

        public static bool operator ==(ValueObject? a, ValueObject? b)
        {
            if (a == null && b == null)
                return true;

            if (a == null || b == null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(ValueObject? a, ValueObject? b)
        {
            return !(a == b);
        }
    }
}
