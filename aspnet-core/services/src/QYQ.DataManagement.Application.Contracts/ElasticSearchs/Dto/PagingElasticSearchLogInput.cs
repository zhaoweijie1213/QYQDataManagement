using System;
using QYQ.DataManagement.Extension.Customs.Dtos;

namespace QYQ.DataManagement.ElasticSearchs.Dto
{
    public class PagingElasticSearchLogInput : PagingBase
    {
        public string Filter { get; set; }

        public DateTime? StartCreationTime { get; set; }

        public DateTime? EndCreationTime { get; set; }
    }
}