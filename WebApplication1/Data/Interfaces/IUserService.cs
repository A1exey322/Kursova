using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Data.Response;
using WebApplication1.ViewModels.User;

namespace WebApplication1.Data.Interfaces
{
    public interface IUserService
    {
        Task<BaseResponse<IEnumerable<UserViewModel>>> GetUsers();
    }
}
