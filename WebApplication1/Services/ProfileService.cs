using System;
using WebApplication1.Data.Enum;
using System.Threading.Tasks;
using WebApplication1.Entity;
using WebApplication1.Models;
using WebApplication1.ViewModels.Profile;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Response;

namespace WebApplication1.Data.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IBaseRepository<Profile> _profileRepository;

        public ProfileService(IBaseRepository<Profile> profileRepository)
        {
            _profileRepository = profileRepository;
        }

        public async Task<IBaseResponse<Profile>> Get(string userName)
        {
            try
            {
                var phone = await _profileRepository.GetAll()
                    .Include(x => x.User)
                    .FirstOrDefaultAsync(x => x.User.Name == userName);
                if (phone == null)
                {
                    return new BaseResponse<Profile>()
                    {
                        Description = "User is not found",
                        StatusCode = StatusCode.UserNotFound
                    };
                }

                return new BaseResponse<Profile>()
                {
                    StatusCode = StatusCode.OK,
                    Data = phone
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Profile>()
                {
                    Description = $"[Get] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public Task<IBaseResponse<Profile>> Create(ProfileViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<PhoneBySlug>> Edit(long id, ProfileViewModel model)
        {
            throw new NotImplementedException();
        }
    }

    public interface IProfileService
    {
        Task<IBaseResponse<Profile>> Get(string userName);

        Task<IBaseResponse<Profile>> Create(ProfileViewModel model);

        Task<IBaseResponse<PhoneBySlug>> Edit(long id, ProfileViewModel model);
    }

}
