namespace GloboTicket.TicketManagement.Application.Features.Rooms.Queries.GetRoomDetail
{
    public class RoomDetailVm
    {
        public Guid RoomId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public RoomCategoryDto Category { get; set; } = default!;
    }
}
