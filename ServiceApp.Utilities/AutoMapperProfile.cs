using AutoMapper;
using ServiceApp.Entities.Models;
using ServiceApp.Utilities.Models;

namespace ServiceApp.Utilities
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserRoleModel, UserRole>().ReverseMap();
            CreateMap<AccountMaster, AccountModel>().ReverseMap();
            CreateMap<StateMaster, StateModel>().ReverseMap();
            CreateMap<CityMaster, CityModel>().ReverseMap();
            CreateMap<CountryMaster, CountryModel>().ReverseMap();
            CreateMap<ServiceMaster, ServiceModel>().ReverseMap();
            CreateMap<ServiceTypeMaster, ServiceTypeModel>().ReverseMap();
        }
    }
}
