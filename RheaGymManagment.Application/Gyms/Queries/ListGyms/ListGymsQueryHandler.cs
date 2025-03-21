using ErrorOr;
using MediatR;
using RheaGymManagment.Application.Commons.interfaces;
using RheaGymManagment.Domain.Gyms;

namespace RheaGymManagment.Application.Gyms.Queries.ListGyms;

public class ListGymsQueryHandler : IRequestHandler<ListGymsQuery, ErrorOr<List<Gym>>>
{
    private readonly IGymsRepository _gymsRepository;
    private readonly IGymRepository _subscriptionsRepository;

    public ListGymsQueryHandler(IGymsRepository gymsRepository, IGymRepository subscriptionsRepository)
    {
        _gymsRepository = gymsRepository;
        _subscriptionsRepository = subscriptionsRepository;
    }

    public async Task<ErrorOr<List<Gym>>> Handle(ListGymsQuery query, CancellationToken cancellationToken)
    {
        if (!await _subscriptionsRepository.ExistsAsync(query.SubscriptionId))
        {
            return Error.NotFound(description: "Subscription not found");
        }

        return await _gymsRepository.ListBySubscriptionIdAsync(query.SubscriptionId);
    }
}
