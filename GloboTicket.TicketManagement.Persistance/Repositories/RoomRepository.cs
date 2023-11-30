using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Persistence.Repositories
{
    public class RoomRepository : BaseRepository<Room>, IRoomRepository
    {
        public RoomRepository(GloboTicketDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> IsRoomNumberUnique(string number)
        {
            var matches = _dbContext.Rooms.Any(e => e.roomNumber.Equals(number));
            return Task.FromResult(matches);
        }
    }
}
