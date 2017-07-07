using System.Collections.Generic;
using System.Linq;

namespace WhiteHingePCL.Classes
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class NewWhlSku
    {
        /// <summary>
        /// The item's sku
        /// </summary>
        public string Sku = string.Empty;

        /// <summary>
        /// The item's retail price
        /// </summary>
        public double RetailPrice = 0.0;
        /// <summary>
        /// The item's title
        /// </summary>
        public string ItemTitle = string.Empty;

        /// <summary>
        /// A list of all locations attached to the item
        /// </summary>
        // ReSharper disable once CollectionNeverUpdated.Global
        public List<LocationData> Locations = new List<LocationData>();

        /// <summary>
        /// A list of all suppliers and relevant data
        /// </summary>
        public List<NewSkuSupplier> Suppliers = new List<NewSkuSupplier>();

        /// <summary>
        /// A list of all barcodes used by the item;
        /// </summary>
        public List<string> Barcodes = new List<string>();
        /// <summary>
        /// Paramless constructor
        /// </summary>
        public NewWhlSku()
        {

        }
        /// <summary>
        /// A simple method to retrieve the first Pickable location of an item. Each item should have only one pickable location.
        /// </summary>
        /// <returns>The LocationData of the picking location</returns>
        public LocationData GetPickingLocation()
        {
            return Locations.First(x => x.LocType == LocationData.LocationType.Pickable);
        }
        /// <summary>
        /// A method to retrieve the locations of an item according to the specified type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<LocationData> ReturnLocationsOfType(LocationData.LocationType type)
        {
            return Locations.Where(x => x.LocType == type).ToList();
        }
    }


}
