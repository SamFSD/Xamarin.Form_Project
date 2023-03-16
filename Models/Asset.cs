// Asset.cs

namespace MyApp.Models
{
    public class Asset
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public bool IsOnline { get; set; }
        public string Alert { get; set; }
        public string Location { get; set; }
    }
}
