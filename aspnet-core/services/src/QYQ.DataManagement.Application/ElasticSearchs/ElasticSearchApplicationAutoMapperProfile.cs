using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QYQ.DataManagement.ElasticSearchs.Dto;

namespace QYQ.DataManagement.ElasticSearchs
{
    public class ElasticSearchApplicationAutoMapperProfile : Profile
    {
        public ElasticSearchApplicationAutoMapperProfile()
        {
            CreateMap<PagingElasticSearchLogDto, PagingElasticSearchLogOutput>();
        }
    }
}