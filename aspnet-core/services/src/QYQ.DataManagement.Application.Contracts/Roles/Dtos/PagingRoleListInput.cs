using QYQ.DataManagement.Extension.Customs.Dtos;

namespace QYQ.DataManagement.Roles.Dtos
{
    public class PagingRoleListInput : PagingBase
    {
        public string Filter { get; set; }
    }
}