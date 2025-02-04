using ErrorOr;
using MediatR;
namespace RheaGymManagment.Application.Rooms.Commands.DeleteRoom;

public record DeleteRoomCommand(Guid GymId, Guid RoomId)
    : IRequest<ErrorOr<Deleted>>;