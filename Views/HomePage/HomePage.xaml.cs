using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace MyApp
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            PopulateAssetGroups();
        }

        private void PopulateAssetGroups()
        {
            // Load the assets from the JSON file
            var assetsJson = DependencyService.Get<IAssetLoader>().LoadAssetJson();
            var assets = JsonConvert.DeserializeObject<List<Asset>>(assetsJson);

            // Group the assets by type
            var assetGroups = assets.GroupBy(a => a.Type)
                                    .Select(g => new AssetGroup
                                    {
                                        Type = g.Key,
                                        Count = g.Count(),
                                        IconSource = GetIconSource(g.Key)
                                    })
                                    .ToList();

            // Bind the asset groups to the list view
            assetGroupsListView.ItemsSource = assetGroups;
        }

        private string GetIconSource(string assetType)
        {
            switch (assetType)
            {
                case "Car":
                    return "car.png";
                case "Truck":
                    return "truck.png";
                case "Generator":
                    return "generator.png";
                case "Fridge":
                    return "fridge.png";
                default:
                    return "";
            }
        }

        private async void assetGroupsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            // Get the selected asset group
            var assetGroup = e.Item as AssetGroup;

            // Load the assets from the JSON file
            var assetsJson = DependencyService.Get<IAssetLoader>().LoadAssetJson();
            var assets = JsonConvert.DeserializeObject<List<Asset>>(assetsJson);

            // Filter the assets by type
            var filteredAssets = assets.Where(a => a.Type == assetGroup.Type).ToList();

            // Navigate to the AssetInfoPage with the filtered assets
            await Navigation.PushAsync(new AssetInfoPage(filteredAssets));
        }
    }
}
