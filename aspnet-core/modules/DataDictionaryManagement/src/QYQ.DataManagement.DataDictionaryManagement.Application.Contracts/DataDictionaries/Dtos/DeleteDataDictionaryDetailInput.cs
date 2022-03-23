using System;

namespace QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Dtos
{
    public class DeleteDataDictionaryDetailInput
    {
        public Guid DataDictionaryId { get; set; }

        public Guid DataDictionayDetailId { get; set; }
    }
}
