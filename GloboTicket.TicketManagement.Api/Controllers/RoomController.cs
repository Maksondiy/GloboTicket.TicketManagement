using GloboTicket.TicketManagement.Application.Features.Rooms.Commands.CreateRoom;
using GloboTicket.TicketManagement.Application.Features.Rooms.Commands.DeleteRoom;
using GloboTicket.TicketManagement.Application.Features.Rooms.Commands.UpdateRoom;
using GloboTicket.TicketManagement.Application.Features.Rooms.Queries.GetRoomDetail;
using GloboTicket.TicketManagement.Application.Features.Rooms.Queries.GetRoomList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GloboTicket.TicketManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoomController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAllRooms")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<RoomListVm>>> GetAllRooms()
        {
            var dtos = await _mediator.Send(new GetRoomsListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetRoomById")]
        public async Task<ActionResult<RoomDetailVm>> GetEventById(Guid id)
        {
            var getRoomDetailQuery = new GetRoomDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getRoomDetailQuery));
        }

        [HttpPost(Name = "AddRoom")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateRoomCommand createRoomCommand)
        {
            var id = await _mediator.Send(createRoomCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateRoom")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateRoomCommand updateRoomCommand)
        {
            await _mediator.Send(updateRoomCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteRoom")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteRoomCommand = new DeleteRoomCommand() { RoomId = id };
            await _mediator.Send(deleteRoomCommand);
            return NoContent();
        }
    }
}
