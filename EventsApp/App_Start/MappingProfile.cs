using AutoMapper;
using EventsApp.DTOs;
using EventsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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