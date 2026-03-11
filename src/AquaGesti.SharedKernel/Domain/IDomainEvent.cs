using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaGesti.SharedKernel.Domain
{
    public class IDomainEvent
    {
        DateTime OccurredOnUtc { get; }
    }
}
