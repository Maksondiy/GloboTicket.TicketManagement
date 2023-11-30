using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Rooms.Commands.CreateRoom
{
    public class CreateRoomCommand : IRequest<Guid>
    {
        public Guid RoomId { get; set; }
        public string? roomNumber { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public Guid CategoryId { get; set; }
        public override string ToString()
        {
            return $"Room name: {Name}; Price: {Price}; Description: {Description}";
        }
    }
}
