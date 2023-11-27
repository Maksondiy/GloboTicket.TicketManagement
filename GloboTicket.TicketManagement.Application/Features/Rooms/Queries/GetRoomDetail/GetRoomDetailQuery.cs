using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Rooms.Queries.GetRoomDetail
{
    public class GetRoomDetailQuery : IRequest<RoomDetailVm>
    {
        public Guid Id { get; set; }
    }
}
