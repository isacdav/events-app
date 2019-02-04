using AutoMapper;
using EventsApp.Core.DTOs;
using EventsApp.Core.Models;

namespace EventsApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            var config = new MapperConfiguration
                (cfg =>
                {
                    cfg.CreateMap<ApplicationUser, UserDto>();
                    cfg.CreateMap<Gig, GigDto>();
                    cfg.CreateMap<Notification, NotificationDto>();
                });
            var mapper = config.CreateMapper();
        }
    }
}