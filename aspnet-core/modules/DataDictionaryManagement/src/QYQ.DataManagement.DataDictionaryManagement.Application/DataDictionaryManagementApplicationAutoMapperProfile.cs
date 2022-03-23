using AutoMapper;
using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Aggregates;
using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Dto;
using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Dtos;

namespace QYQ.DataManagement.DataDictionaryManagement
{
    public class DataDictionaryManagementApplicationAutoMapperProfile : Profile
    {
        public DataDictionaryManagementApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<DataDictionary, PagingDataDictionaryOutput>();
            CreateMap<DataDictionaryDetail, PagingDataDictionaryDetailOutput>();
        }
    }
}