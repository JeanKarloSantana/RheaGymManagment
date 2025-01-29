using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RheaGymManagment.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Infrastructure.Subscriptions.Persistence
{
    public class SubscriptionConfigutation : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
           builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .ValueGeneratedNever();

            builder.Property("_adminId")
                .HasColumnName("AdminId");

            builder.Property(s => s.SubscriptionType)
                .HasConversion(suscriptionType => suscriptionType.Value, 
                value => SubscriptionType.FromValue(value));
        }
    }
}
