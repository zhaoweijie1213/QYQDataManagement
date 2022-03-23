using QYQ.DataManagement.Extension.Customs.Dtos;

namespace QYQ.DataManagement.Users.Dtos
{
    public class PagingUserListInput : PagingBase
    {
        /// <summary>
        /// 关键字
        /// </summary>
        public string Filter { get; set; }
    }
}