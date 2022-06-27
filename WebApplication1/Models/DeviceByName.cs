using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class DeviceByName
    {
        public DataByName data { get; set; }
    }
    public class DataByName
    {
        public List<DevicesByName> phones {get; set;}     
    }
    public class DevicesByName
    {
        public string brand { get; set; }
        public string phone_name { get; set; }
        public string slug { get; set; }
        public string image { get; set; }
        public string detail { get; set; }
    }
}
