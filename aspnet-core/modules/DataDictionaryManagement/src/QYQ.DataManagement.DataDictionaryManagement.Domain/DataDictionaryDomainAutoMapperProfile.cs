using AutoMapper;
using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Aggregates;
using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Dto;

namespace QYQ.DataManagement.DataDictionaryManagement
{
    public class DataDictionaryDomainAutoMapperProfile : Profile
    {
        public DataDictionaryDomainAutoMapperProfile()
        {
            CreateMap<DataDictionary, DataDictionaryDto>();
            CreateMap<DataDictionaryDetail, DataDictionaryDetailDto>();
        }
    }
}