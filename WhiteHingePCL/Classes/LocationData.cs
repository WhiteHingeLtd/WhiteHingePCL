using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// ReSharper disable NotAccessedField.Global
// ReSharper disable MemberCanBePrivate.Global

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// Location data used for Skus
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public partial class LocationData
    {
        /// <summary>
        /// 
        /// </summary>
        public string SkuLocationId;

        /// <summary>
        /// 
        /// </summary>
        public string ShelfName;

        /// <summary>
        /// 
        /// </summary>
        public string Sku;

        /// <summary>
        /// 
        /// </summary>
        public int LocationReferenceId;

        /// <summary>
        /// 
        /// </summary>
        public string LocationWarehouse;

        /// <summary>
        /// The current route index for this location
        /// </summary>
        public int PickRoute;

        /// <summary>
        /// The stocklevel in the location
        /// </summary>
        public int StockLevel;
        /// <summary>
        /// 
        /// </summary>
        public LocationType LocType = LocationType.Unused;
        /// <summary>
        /// Constructor for use with the SelectDataDictionaryMethod from framework
        /// </summary>
        /// <param name="dataDict">Requires a line from sku_locations with locationreference attached</param>
        public LocationData(Dictionary<string, object> dataDict)
        {
            SkuLocationId = dataDict["id"].ToString();
            ShelfName = dataDict["shelfName"].ToString();
            Sku = dataDict["Sku"].ToString();
            LocationReferenceId = Convert.ToInt32(dataDict["locID"]);
            LocationWarehouse = ((Warehouse)Convert.ToInt32(dataDict["locWarehouse"])).ToString();
            PickRoute = Convert.ToInt32(dataDict["RouteID"]);
            StockLevel = Convert.ToInt32(dataDict["additionalInfo"]);
            LocType = (LocationType)Convert.ToInt32(dataDict["locType"]);
        }

        /// <summary>
        /// Parameterless constructor for use with Newtonsoft
        /// </summary>
        [JsonConstructor]
        public LocationData()
        {

        }
    }
}
