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
            var roomDetailDto = _mapper.Map<RoomDetailVm>(@room);

            var roomcategory = await _roomcategoryRepository.GetByIdAsync(@room.CategoryId);


            roomDetailDto.Category = _mapper.Map<RoomCategoryDto>(roomcategory);

            return roomDetailDto;
        }
    }
}
