using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Exceptions;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Rooms.Commands.DeleteRoom
{
    public class DeleteRoomCommandHandler : IRequestHandler<DeleteRoomCommand, Unit>
    {
        private readonly IAsyncRepository<Room> _roomRepository;
        private readonly IMapper _mapper;

        public DeleteRoomCommandHandler(IMapper mapper, IAsyncRepository<Room> roomRepository)
        {
            _mapper = mapper;
            _roomRepository = roomRepository;
        }

        public async Task<Unit> Handle(DeleteRoomCommand request, CancellationToken cancellationToken)
        {
            var roomToDelete = await _roomRepository.GetByIdAsync(request.RoomId);

            if (roomToDelete == null)
            {
                throw new NotFoudException(nameof(Event), request.RoomId);
            }

            await _roomRepository.DeleteAsync(roomToDelete);

            return Unit.Value;
        }

    }
}
