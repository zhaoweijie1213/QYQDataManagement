using QYQ.DataManagement.Extension.Customs.Dtos;

namespace QYQ.DataManagement.FileManagement.Files.Dto;

public class PagingFileInput : PagingBase
{
    public string Filter { get; set; }
}