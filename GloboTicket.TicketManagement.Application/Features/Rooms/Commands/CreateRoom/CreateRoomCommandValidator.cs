using FluentValidation;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Rooms.Commands.CreateRoom
{
    public class CreateRoomCommandValidator : AbstractValidator<CreateRoomCommand>
    {
        private readonly IRoomRepository _roomRepository;
        public CreateRoomCommandValidator(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0);
        }
        private async  Task<bool> IsRoomNumberUnique(CreateRoomCommand e, CancellationToken token)
        {
            return !(await _roomRepository.IsRoomNumberUnique(e.roomNumber));
        }
    }
}

