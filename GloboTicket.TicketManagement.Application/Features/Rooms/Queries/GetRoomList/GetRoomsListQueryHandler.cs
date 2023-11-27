using MediatR;
using AutoMapper;
using GloboTicket.TicketManagement.Domain.Entities;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;

namespace GloboTicket.TicketManagement.Application.Features.Rooms.Queries.GetRoomList
{
    public class GetRoomsListQueryHandler : IRequestHandler<GetRoomsListQuery, List<RoomListVm>>
    {
        private readonly IAsyncRepository<Room> _roomRepository;
        private readonly IMapper _mapper;

        public GetRoomsListQueryHandler(IMapper mapper, IAsyncRepository<Room> roomRepository)
        {
            _mapper = mapper;
            _roomRepository = roomRepository;
        }

        public async Task<List<RoomListVm>> Handle(GetRoomsListQuery request, CancellationToken cancellationToken)
        {
            var allRooms = (await _roomRepository.ListAllAsync()).OrderBy(x => x.Name);
            return _mapper.Map<List<RoomListVm>>(allRooms);
        }
    }
}
