using AutoMapper;
using QYQ.DataManagement.Users.Dtos;
using Volo.Abp.Identity;

namespace QYQ.DataManagement
{
    public class DataManagementApplicationAutoMapperProfile : Profile
    {
        public DataManagementApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<IdentityUser, ExportIdentityUserOutput>()
                .ForMember(e => e.CreationTimeFormat, opt => opt.Ignore())
                .ForMember(e => e.Status, opt => opt.Ignore());
        }
    }
}
