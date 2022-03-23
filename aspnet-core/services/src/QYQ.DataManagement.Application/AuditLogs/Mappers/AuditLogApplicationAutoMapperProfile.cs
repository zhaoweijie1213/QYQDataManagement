using AutoMapper;
using Volo.Abp.AuditLogging;

namespace QYQ.DataManagement.AuditLogs.Mappers
{
    public class AuditLogApplicationAutoMapperProfile:Profile
    {
        public AuditLogApplicationAutoMapperProfile()
        {
            CreateMap<AuditLog, GetAuditLogPageListOutput>();
        }   
    }
}