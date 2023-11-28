using AutoMapper;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;

namespace GloboTicket.TicketManagement.Application.Features.Rooms.Queries.GetRoomDetail
{
    public class GetEventDetailQueryHandler : IRequestHandler<GetRoomDetailQuery, RoomDetailVm>
    {
        private readonly IAsyncRepository<Room> _roomRepository;
        private readonly IAsyncRepository<RoomCategory> _roomcategoryRepository;
        private readonly IMapper _mapper;

        public GetEventDetailQueryHandler(IMapper mapper, IAsyncRepository<Room> roomRepository, IAsyncRepository<RoomCategory> roomcategoryRepository)
        {
            _mapper = mapper;
            _roomRepository = roomRepository;
            _roomcategoryRepository = roomcategoryRepository;
        }

        public async Task<RoomDetailVm> Handle(GetRoomDetailQuery request, CancellationToken cancellationToken)
        {
            var @room = await _roomRepository.GetByIdAsync(request.Id);
            var eventDetailDto = _mapper.Map<RoomDetailVm>(@room);

            var category = await _roomcategoryRepository.GetByIdAsync(@room.RoomId);


            eventDetailDto.Category = _mapper.Map<RoomCategoryDto>(category);

            return eventDetailDto;
        }
    }
}
