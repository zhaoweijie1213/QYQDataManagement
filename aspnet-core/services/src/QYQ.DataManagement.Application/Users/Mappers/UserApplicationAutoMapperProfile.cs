using AutoMapper;
using QYQ.DataManagement.Users.Dtos;

namespace QYQ.DataManagement.Users.Mappers
{
    public class UserApplicationAutoMapperProfile:Profile
    {
        public UserApplicationAutoMapperProfile()
        {
            CreateMap<Volo.Abp.Identity.IdentityUser, LoginOutput>();
        }
    }
}