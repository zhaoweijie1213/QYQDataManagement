using System.ComponentModel.DataAnnotations;

namespace QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Dtos
{
    public class CreateDataDictinaryInput
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string DisplayText { get; set; }
        public string Description { get; set; }
    }
}