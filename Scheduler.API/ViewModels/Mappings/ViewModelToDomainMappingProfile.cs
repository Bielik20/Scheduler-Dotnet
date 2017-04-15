using AutoMapper;
using Scheduler.Model.Entities;
using System.Collections.Generic;

namespace Scheduler.API.ViewModels.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ScheduleViewModel, Schedule>()
               .ForMember(s => s.Creator, map => map.Ignore())
               .ForMember(s => s.Attendees, map => map.UseValue(new List<Attendee>()));

            CreateMap<UserViewModel, User>();
        }
    }
}
