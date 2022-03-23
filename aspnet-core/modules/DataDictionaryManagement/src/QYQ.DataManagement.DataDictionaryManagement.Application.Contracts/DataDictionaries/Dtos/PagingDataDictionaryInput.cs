using QYQ.DataManagement.Extension.Customs.Dtos;

namespace QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Dtos
{
    public class PagingDataDictionaryInput : PagingBase
    {
        public string Filter { get; set; }
    }
}