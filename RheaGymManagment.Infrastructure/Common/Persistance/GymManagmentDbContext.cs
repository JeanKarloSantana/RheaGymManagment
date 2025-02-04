using Microsoft.EntityFrameworkCore;
using RheaGymManagment.Application.Commons.interfaces;
using RheaGymManagment.Domain.Admin;
using RheaGymManagment.Domain.Gyms;
using RheaGymManagment.Domain.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Infrastructure.Common.Persistance
{
    public class GymManagementDbContext : DbContext, IUnitOfWork
    {
        public DbSet<Admin> Admins { get; set; } = null!;
        public DbSet<Subscription> Subscriptions { get; set; } = null!;
        public DbSet<Gym> Gyms { get; set; } = null!;

        public GymManagementDbContext(DbContextOptions options) : base(options)
        {
        }

        public async Task CommitChangesAsync()
        {
            await SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
