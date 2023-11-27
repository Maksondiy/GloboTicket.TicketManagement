using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.Categories.Commands.CreateCateogry;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoryListWithEvents;
using GloboTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using GloboTicket.TicketManagement.Application.Features.Events.Commands.DeleteEvent;
using GloboTicket.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventList;
using GloboTicket.TicketManagement.Application.Features.Rooms.Commands.CreateRoom;
using GloboTicket.TicketManagement.Application.Features.Rooms.Commands.UpdateRoom;
using GloboTicket.TicketManagement.Application.Features.Rooms.Queries.GetRoomDetail;
using GloboTicket.TicketManagement.Application.Features.Rooms.Queries.GetRoomList;
using GloboTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Profiles
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<Event, EventListVm>().ReverseMap();
            //CreateMap<Event, EventDetailVm>().ReverseMap();
            //CreateMap<Category, CategoryDto>();
            //CreateMap<Category, CategoryListVm>();
            //CreateMap<Category, CategoryEventListVm>();

            //CreateMap<Event, CreateEventCommand>();
            //CreateMap<Event, DeleteEventCommand>();
            //CreateMap<Event, UpdateEventCommand>();

            CreateMap<Room, RoomListVm>().ReverseMap();
            CreateMap<Room, CreateRoomCommand>().ReverseMap();
            CreateMap<Room, UpdateRoomCommand>().ReverseMap();
            CreateMap<Room, RoomDetailVm>().ReverseMap();
            CreateMap<Room, RoomCategoryDto>().ReverseMap();

            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

        }
    }
}
