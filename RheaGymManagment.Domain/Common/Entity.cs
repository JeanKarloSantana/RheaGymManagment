using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Domain.Common
{
    public abstract class Entity
    {
        public Guid Id { get; init; }

        private readonly List<IDomainEvent> _domainEvents = [];

        protected Entity(Guid id) => Id = id;

        protected Entity() { }
    }
}
