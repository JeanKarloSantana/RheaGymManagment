using Microsoft.EntityFrameworkCore;
using RheaGymManagment.Application.Commons.interfaces;
using RheaGymManagment.Domain.Admin;
using RheaGymManagment.Infrastructure.Common.Persistance;

namespace GymManagement.Infrastructure.Admins.Persistence;

public class AdminsRepository : IAdminsRepository
{
    private readonly GymManagementDbContext _dbContext;

    public AdminsRepository(GymManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<Admin?> GetByIdAsync(Guid adminId)
    {
        return _dbContext.Admins.FirstOrDefaultAsync(a => a.Id == adminId);
    }

    public Task UpdateAsync(Admin admin)
    {
        _dbContext.Admins.Update(admin);

        return Task.CompletedTask;
    }
}