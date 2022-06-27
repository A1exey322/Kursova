using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Clients
{
    public class PhoneClient
    {

        private readonly HttpClient _client;
        private static string _address;
        private readonly HttpRequestMessage _request;

        public PhoneClient()
        {
           _address = Constants.Address;
           _client = new HttpClient();
           _request = new HttpRequestMessage();
        }

        public async Task<PhoneBySlug> GetPhoneAsync(string slug)
        {
            _request.RequestUri = new Uri(_address + $"/{slug}");
            var response = await _client.SendAsync(_request);
            response.EnsureSuccessStatusCode();
            var content =  response.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<PhoneBySlug>(content);

            return result;

        }

        public async Task<Brand> GetBrandsAsync()
        {
            _request.RequestUri = new Uri(_address + "/brands");
            var response = await _client.SendAsync(_request);
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<Brand>(content);

            return result;

        }

        public async Task<TopPhones> TopPhonesByInterestAsync()
        {
            _request.RequestUri = new Uri(_address + "/top-by-interest");
            var response = await _client.SendAsync(_request);
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<TopPhones>(content);

            return result;
        }

        public async Task<DeviceByName> GetPhoneByNameAsync(string name)
        {
            _request.RequestUri = new Uri(_address + $"/search?query= {name}");
            var responce = await _client.SendAsync(_request);
            responce.EnsureSuccessStatusCode();
            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<DeviceByName>(content);

            return result;
        }

        public async Task<DeviceByName> GetWatches(string name)
        {
            _request.RequestUri = new Uri(_address + $"/search?query= {name}");
            var responce = await _client.SendAsync(_request);
            responce.EnsureSuccessStatusCode();
            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<DeviceByName>(content);

            return result;
        }

        public async Task<DeviceByName> GetDevicesByBrand(string slug)
        {
            _request.RequestUri = new Uri(_address + $"/brands/{slug}?page=1");
            var responce = await _client.SendAsync(_request);
            responce.EnsureSuccessStatusCode();
            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<DeviceByName>(content);

            return result;
        }



        //Top/////////////////////////

        //public async Task<>
    }
}
