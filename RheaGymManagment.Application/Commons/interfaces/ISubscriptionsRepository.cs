using RheaGymManagment.Domain.Subscriptions;

namespace RheaGymManagment.Application.Commons.interfaces;

public interface IGymRepository
{
    Task AddSubscriptionAsync(Subscription subscription);
    Task<bool> ExistsAsync(Guid id);
    Task<Subscription?> GetByAdminIdAsync(Guid adminId);
    Task<Subscription?> GetByIdAsync(Guid id);
    Task<List<Subscription>> ListAsync();
    Task RemoveSubscriptionAsync(Subscription subscription);
    Task UpdateAsync(Subscription subscription);
}