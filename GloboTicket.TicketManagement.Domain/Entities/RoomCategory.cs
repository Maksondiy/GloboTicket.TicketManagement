using GloboTicket.TicketManagement.Domain.Common;

namespace GloboTicket.TicketManagement.Domain.Entities
{
    public class RoomCategory: AuditableEntity
    {
        public Guid RoomCategoryId { get; set; }
        public string? roomNumber { get; set; } = string.Empty;
        public ICollection<Room>? Rooms { get; set; }
    }
}
