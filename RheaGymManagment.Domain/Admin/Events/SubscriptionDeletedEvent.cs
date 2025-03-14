using RheaGymManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Domain.Admin.Events
{
    public record SubscriptionDeletedEvent(Guid SubscriptionId) : IDomainEvent;
}
