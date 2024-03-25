using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;

namespace TraversalCoreProje.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDtos, Announcement>().ReverseMap();
            CreateMap<AppUserRegisterDTOs,AppUser>().ReverseMap();
            CreateMap<AppUserLoginDTOs, AppUser>().ReverseMap(); ;
          
        }
    }
}
