using ErrorOr;
using GymManagement.Domain.Rooms;
using MediatR;

namespace RheaGymManagment.Application.Rooms.Commands.CreateRoom;

public record CreateRoomCommand(
    Guid GymId,
    string RoomName) : IRequest<ErrorOr<Room>>;