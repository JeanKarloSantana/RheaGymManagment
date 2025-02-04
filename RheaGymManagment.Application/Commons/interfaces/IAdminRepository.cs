using RheaGymManagment.Domain.Admin;

namespace RheaGymManagment.Application.Commons.interfaces;

public interface IAdminsRepository
{
    Task<Admin?> GetByIdAsync(Guid adminId);
    Task UpdateAsync(Admin admin);
}