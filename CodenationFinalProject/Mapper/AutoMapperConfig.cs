using AutoMapper;
using CodenationFinalProject.Models;
using CodenationFinalProject.ViewModel;

namespace CodenationFinalProject.Mapper
{
    public class AutoMapperConfig : Profile
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(x => x.AllowNullCollections = true);
        }

        public AutoMapperConfig()
        {
            CreateMap<Logs, LogsDTO>().ReverseMap();
            CreateMap<Error, ErrorDTO>().ReverseMap();
            CreateMap<Users, UsersDTO>().ReverseMap();
        }
    }
}
