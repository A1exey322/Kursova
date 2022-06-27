namespace WebApplication1.Models
{
    public class PhoneBySlug
    {
        public DataBySlug data { get; set; }  
    }
    public class DataBySlug
    {
        public string brand { get; set; }
        public string phone_name { get; set; }
        public string thumbnail { get; set; }
        public string release_date { get; set; }
        public string[] phone_images { get; set; }
        public string os { get; set; }
        public string storage { get; set; }


    }
}
