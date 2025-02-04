using ErrorOr;

using MediatR;
using RheaGymManagment.Domain.Rooms;

namespace RheaGymManagment.Application.Rooms.Commands.CreateRoom;

public record CreateRoomCommand(
    Guid GymId,
    string RoomName) : IRequest<ErrorOr<Room>>;