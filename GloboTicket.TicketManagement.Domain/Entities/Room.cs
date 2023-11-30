using GloboTicket.TicketManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Domain.Entities
{
    public class Room: AuditableEntity
    {
        public Guid RoomId { get; set; }
        public string? roomNumber { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public Guid CategoryId { get; set; }
    }
}
