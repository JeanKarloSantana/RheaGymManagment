using Microsoft.EntityFrameworkCore;
using RheaGymManagment.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Infrastructure.Common.Persistance
{
    public class GymManagmentDbContext : DbContext
    {
        public DbSet<Subscription> Subscriptions { get; set; } = null!;

        public GymManagmentDbContext(DbContextOptions options) : base(options)
        {           
        }
    }
}
