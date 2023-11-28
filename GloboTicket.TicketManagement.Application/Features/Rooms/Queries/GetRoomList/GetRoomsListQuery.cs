
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Rooms.Queries.GetRoomList
{
    public class GetRoomsListQuery : IRequest<List<RoomListVm>>
    {
    }
}
