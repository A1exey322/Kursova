using System.Collections.Generic;
using System.Text.Json;

namespace WebApplication1.Models
{
    public class TopPhones
    {

        public string image = "https://www.ferra.ru/thumb/0x938/filters:quality(75):no_upscale()/imgs/2022/05/29/00/5425983/78cd15a51d790fb38c914e8896512f46003792ac.png";

        public TopPhonesData data { get; set; }

    }
    public class TopPhonesData
    {
        public string title { get; set; }

        public List<Phones> phones { get; set; }
    }
    public class Phones
    {
        public string phone_name { get; set; }
        public string slug  { get; set; }
        public string hits { get; set; }
        public string detail { get; set; }

    }
}
