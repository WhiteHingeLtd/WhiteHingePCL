using System;
using System.Collections.Generic;

namespace WhiteHingePCL.Classes
{
    public class LocationData
    {
        /// <summary>
        /// 
        /// </summary>
        public string SkuLocationId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShelfName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Sku { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int LocationReferenceId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LocationWarehouse { get; set; }
        /// <summary>
        /// The current route index for this location
        /// </summary>
        public int PickRoute { get; set; }
        /// <summary>
        /// The stocklevel in the location
        /// </summary>
        public int StockLevel { get; set; }
        /// <summary>
        /// An enum which is used to select the correct warehouse for a location
        /// </summary>
        public enum Warehouse
        {
            /// <summary>
            /// Unit 14
            /// </summary>
            Unit14 = 1,
            /// <summary>
            /// Unit 1
            /// </summary>
            Unit1 = 2,
            /// <summary>
            /// Test warehouse
            /// </summary>
            Test = 3
        }

        /// <summary>
        /// An enum used to describe the location type of the location
        /// </summary>
        public enum LocationType
        {
            /// <summary>
            /// Unused Location. This indicates an error with the location
            /// </summary>
            Unused = -1,
            /// <summary>
            /// Storage Locations
            /// </summary>
            Storage = 0,
            /// <summary>
            /// Pickable locations
            /// </summary>
            Pickable = 1,
            /// <summary>
            /// Prepack storage
            /// </summary>
            Prepack = 2,
            /// <summary>
            /// Delivery Storage
            /// </summary>
            Delivery = 3,
            /// <summary>
            /// Priority Prepack Locations
            /// </summary>
            PrepackInstant = 4,
            /// <summary>
            /// Items which have been transformed in Prepack
            /// </summary>
            PrepackComplete = 5,
            /// <summary>
            /// Damaged Items
            /// </summary>
            Damaged = 6,
            /// <summary>
            /// Items which have lost their locations
            /// </summary>
            Lost = 7,
            /// <summary>
            /// Returned items
            /// </summary>
            Returns = 8
        }
        /// <summary>
        /// 
        /// </summary>
        public LocationType LocType = LocationType.Unused;
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public LocationData()
        {

        }
    }
}
