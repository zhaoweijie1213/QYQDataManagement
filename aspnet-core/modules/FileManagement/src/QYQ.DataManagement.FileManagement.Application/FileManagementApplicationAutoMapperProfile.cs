using AutoMapper;
using QYQ.DataManagement.FileManagement.Files;
using QYQ.DataManagement.FileManagement.Files.Dto;

namespace QYQ.DataManagement.FileManagement;

public class FileManagementApplicationAutoMapperProfile : Profile
{
    public FileManagementApplicationAutoMapperProfile()
    {
        CreateMap<File, PagingFileOutput>();
    }
}