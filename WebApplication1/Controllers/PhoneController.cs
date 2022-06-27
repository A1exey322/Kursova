using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Clients;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("/[controller]/Index")]
    public class PhoneController : Controller
    {
        private readonly PhoneClient _phoneClient;

        private readonly ILogger<PhoneController> _logger;

        public PhoneController(ILogger<PhoneController> logger, PhoneClient phoneClient)
        {
            _logger = logger;
            _phoneClient = phoneClient;
        }

        /// <summary>
        /// Search phone by slug
        /// </summary>
        /// <param name="slug"></param>
        /// <returns>View with information about phone with such slug </returns>
        [HttpGet]
        [Route("/[controller]/GetPhone")]
        public async Task<IActionResult> GetPhoneBySlug(string slug)
        {

            var phones = await _phoneClient.GetPhoneAsync(slug);

            return PartialView("GetPhone", phones);
        }

        /// <summary>
        /// Search all brands
        /// </summary>
        /// <returns>View with information about all avaluable brands </returns>
        [HttpGet]
        [Route("/[controller]/Brands")]
        public async Task<IActionResult> GetBrands()
        {

            var brands = await _phoneClient.GetBrandsAsync();

            return View("Brands", brands);
        }


        [HttpGet]
        [Route("/[controller]/DeviceByBrand")]
        public async Task<IActionResult> GetDeviceByBrand(string slug)
        {

            var phones = await _phoneClient.GetDevicesByBrand(slug);

            return View("TopDevices", phones);
        }
        /// <summary>
        /// Search current top 10 phones
        /// </summary>
        /// <returns>View with information about phone with such name </returns>
        [HttpGet]
        [Route("/[controller]/topPhones")]
        public async Task<IActionResult> TopPhones()
        {

            var top_phones = await _phoneClient.TopPhonesByInterestAsync();

            return View("TopPhones", top_phones);
        }


        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            var phones = await _phoneClient.GetPhoneByNameAsync("iphone");
            
            return View("Phone", phones);
        }
        /// <summary>
        /// Search phone by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>View with information about phone with such name </returns>
        [HttpGet]
        [Route("/[controller]/PhoneByName")]
        public async Task<IActionResult> GetPhoneByName(string name)
        {
            
            var phones = await _phoneClient.GetPhoneByNameAsync(name);

            return View("Phone",phones);
        }


        [HttpGet]
        [Route("/[controller]/Watches")]
        public async Task<IActionResult> GetWatch()
        {
            
            var phones = await _phoneClient.GetWatches("watch");

            return View("TopDevices", phones);
        }

        
    }
}
