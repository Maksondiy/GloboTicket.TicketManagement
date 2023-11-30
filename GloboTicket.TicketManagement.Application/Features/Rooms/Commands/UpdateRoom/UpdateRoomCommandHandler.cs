using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Rooms.Commands.UpdateRoom
{
    public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommand, Unit>
    {
        private readonly IAsyncRepository<Room> _roomRepository;
        private readonly IMapper _mapper;

        public UpdateRoomCommandHandler(IAsyncRepository<Room> roomRepository, IMapper mapper)
        {
            _roomRepository = roomRepository;
            _mapper = mapper;

        }

        public async Task<Unit> Handle(UpdateRoomCommand request, CancellationToken cancellationToken)
        {
            var roomToUpdate = await _roomRepository.GetByIdAsync(request.RoomId);
            _mapper.Map(request, roomToUpdate, typeof(UpdateRoomCommand), typeof(Room)); 
            await _roomRepository.UpdateAsync(roomToUpdate);
            return Unit.Value;
        }
    }
}
