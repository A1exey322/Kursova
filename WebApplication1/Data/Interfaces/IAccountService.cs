using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication1.Data.Response;
using WebApplication1.ViewModels.Account;

namespace WebApplication1.Data.Interfaces
{
    public interface IAccountService
    {
        Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model);

        Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model);
    }
}
