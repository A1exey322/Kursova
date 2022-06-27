using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.Entity;
using WebApplication1.Data.Extensions;
using WebApplication1.ViewModels.User;
using WebApplication1.Data.Response;
using WebApplication1.Data.Enum;
using WebApplication1.Models;
using System.Text.Json;

namespace WebApplication1.Data.Services
{
        public class UserService : IUserService
        {
            private readonly IBaseRepository<User> _userRepository;

            public UserService(IBaseRepository<User> userRepository)
            {
                _userRepository = userRepository;
            }

            public async Task<BaseResponse<IEnumerable<UserViewModel>>> GetUsers()
            {
                try
                {
                    var users = _userRepository.GetAll()
                        .Select(x => new UserViewModel()
                        {
                            Id = x.Id,
                            Name = x.Name,
                            Role = x.Role.GetDisplayName(),
                            Like = x.Liked 
                           
                        });

                    return new BaseResponse<IEnumerable<UserViewModel>>()
                    {
                        Data = users,
                        StatusCode = StatusCode.OK
                    };
                }
                catch (Exception ex)
                {
                    throw;
                }
            }


        }
}
