using System.Threading.Tasks;
using WebApplication1.ViewModels.Profile;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Services;

namespace WebApplication1.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet]
        public async Task<IActionResult> ProfileInfo()
        {
            var userName = User.Identity?.Name;
            var response = await _profileService.Get(userName);
            if (response.StatusCode == Data.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return View();
        }

        [HttpGet]
        public IActionResult Save() => PartialView();

        [HttpPost]
        public async Task<IActionResult> Save(ProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id == 0)
                {
                    await _profileService.Create(model);
                }
                else
                {
                    await _profileService.Edit(model.Id, model);
                }
                return RedirectToAction("ProfileInfo");
            }
            return View();
        }
    }
}
