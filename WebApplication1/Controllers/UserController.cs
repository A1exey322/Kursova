
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApplication1.Models;
using System.Collections.Generic;
using WebApplication1.Entity;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace WebApplication1.Controllers
{
    
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        private readonly ApplicationDbContext _db;
        public UserController(IUserService userService, ApplicationDbContext db)
        {
            _userService = userService;
            _db = db;
        }

        public async Task<IActionResult> GetUsers()
        {
            var response = await _userService.GetUsers();
            if (response.StatusCode == Data.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> LikeDevice(PhoneBySlug phonebyslug)
        {
            List<PhoneBySlug> devices = new List<PhoneBySlug>();
            User curuser = await _db.Users.FirstOrDefaultAsync(user => user.Name == User.Identity.Name);
            if (curuser.Liked != null)
                devices = JsonSerializer.Deserialize<List<PhoneBySlug>>(curuser.Liked);


            devices.Add(phonebyslug);
            curuser.Liked = JsonSerializer.Serialize(devices);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index", "Phone");
        }



        //[HttpPost]
        //[Route("~/[controller]/LikeRecept")]
        //public void LikeDevice(string slug)
        //{
        //    var login = Request.Cookies["login"];
        //    if (!string.IsNullOrEmpty(login))
        //    {
        //        MealFull likedmeal;
        //        HttpClient client = new HttpClient();
        //        HttpRequestMessage message = new HttpRequestMessage()
        //        {
        //            Method = HttpMethod.Get,
        //            RequestUri = new Uri($"https://api.spoonacular.com/recipes/{id}/information?apiKey=83c7e059495b468e87e5ea32c1215288")
        //        };
        //        using (var response = client.Send(message))
        //        {
        //            var res = response.Content.ReadAsStringAsync().Result;
        //            likedmeal = JsonSerializer.Deserialize<MealFull>(res);
        //        }
        //        db.Users.Where(user => user.login == login)?.First()?.AddRecipe(likedmeal, login);
        //        db.SaveChanges();
        //    }
        //}

    }
}
