using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Brand
    {

        public List<BrandData> data { get; set; }

    }
    public class BrandData
    {
        public int brand_id { get; set; }

        public string brand_name { get; set; }

        public string brand_slug { get; set; }

        public int device_count { get; set; }

        public string detail { get; set; }
    }
}
