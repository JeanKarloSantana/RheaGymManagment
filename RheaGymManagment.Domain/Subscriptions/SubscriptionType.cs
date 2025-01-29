using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Domain.Subscriptions
{
    public class SubscriptionType : SmartEnum<SubscriptionType>
    {
        private static readonly SubscriptionType Free = new(nameof(Free), 0);
        private static readonly SubscriptionType Starter = new(nameof(Starter), 1);
        private static readonly SubscriptionType Pro = new(nameof(Pro), 2);

        public SubscriptionType(string name, int value) : base(name, value)
        {

        }
    }
}
