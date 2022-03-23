
using System.Threading.Tasks;
using QYQ.DataManagement.Users.Dtos;
using Volo.Abp.Application.Services;



namespace QYQ.DataManagement.Users
{
    public interface IAccountAppService: IApplicationService
    {
        Task<LoginOutput> LoginAsync(LoginInput input);

        Task<LoginOutput> StsLoginAsync(string accessToken);
  
    }
}
