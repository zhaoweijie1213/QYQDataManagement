using System;
using QYQ.DataManagement.Extension.Customs.Dtos;


namespace QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Dtos
{
    public class PagingDataDictionaryDetailInput : PagingBase
    {
        public Guid DataDictionaryId { get; set; }
        public string Filter { get; set; }
    }
}