// AssetGroup.cs

using System.Collections.Generic;

namespace MyApp.Models
{
    public class AssetGroup
    {
        public string Name { get; set; }
        public List<Asset> Assets { get; set; }
    }
}
