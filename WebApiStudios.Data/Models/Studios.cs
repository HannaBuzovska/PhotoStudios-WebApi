using System.ComponentModel.DataAnnotations;

namespace WebApiStudios.Data.Models
{
    public class Studios
    {
        [Key]
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string price { get; set; }
        public string photo { get; set; }
        public string link { get; set; }
        public string addressLink { get; set; }
    }
}