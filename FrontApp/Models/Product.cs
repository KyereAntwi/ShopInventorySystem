using System;

namespace FrontApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public DateTime TimeStamp { get; set; }
        public byte[] Avatar { get; set; }
    }
}
