using Microsoft.EntityFrameworkCore;
using RheaGymManagment.Application.Commons.interfaces;
using RheaGymManagment.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Infrastructure.Common.Persistance
{
    public class GymManagmentDbContext : DbContext, IUnitOfWork
    {
        public DbSet<Subscription> Subscriptions { get; set; } = null!;

        public GymManagmentDbContext(DbContextOptions options) : base(options)
        {           
        }

        public async Task CommitChangesAsync()
        {
           await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
