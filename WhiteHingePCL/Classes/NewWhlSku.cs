﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// A New Sku class to be used across multiple platforms, containing only the required data
    /// </summary>
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
        /// 
        /// </summary>
        public int Packsize => int.TryParse(Sku.Substring(7), out int i) ? i : 0;
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
        /// The combined weekly sales of an Item and its packsizes
        /// </summary>
        public double WeeklySales;

        /// <summary>
        /// 
        /// </summary>
        public NewSkuData NewData;
        
        /// <summary>
        /// Paramless constructor
        /// </summary>
        [JsonConstructor]
        public NewWhlSku()
        {

        }
        #region Methods
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
        /// <summary>
        /// Finds the primary supplier for an item
        /// </summary>
        /// <returns>Returns the Supplier</returns>
        public NewSkuSupplier GetPrimarySupplier()
        {
            return Suppliers.First(x => x.SupplierIsPrimary);
        }
        /// <summary>
        /// Checks if the stock level of the item is greater than 0 in the picking location (i.e can be picked with no issues)
        /// </summary>
        /// <returns>True if there is stock, else false</returns>
        public bool HasStockInPrimaryLocation()
        {
            return GetPickingLocation().StockLevel > 0;
        }
        /// <summary>
        /// Checks if the Item has the required amount of stock.
        /// </summary>
        /// <param name="quantity">The amount of stock required by an order</param>
        /// <returns></returns>
        public bool HasRequiredStockInPrimaryLocation(int quantity)
        {
            return GetPickingLocation().StockLevel >= quantity;
        }


        /// <summary>
        /// Checks if the item is discontinued on all of the suppliers.
        /// </summary>
        /// <returns></returns>
        public bool IsDiscontinued()
        {
            return Suppliers.All(supplier => supplier.SupplierIsDiscontinued);
        }

        /// <summary>
        /// Gets the amount of stock of this item in all locations.
        /// 
        /// </summary>
        /// <returns>The amount of stock for this packsize. This is units of this packsize, not single units. So 4 packs of 10 would return 4, not 40, for example.</returns>
        public int StockLevel()
        {
            var returnable = 0;
            foreach (LocationData location in Locations)
            {
                returnable += location.StockLevel;
            }
            return returnable;
        }

        #endregion
        /// <summary>
        /// 
        /// </summary>
        public class NewSkuData
        {
            /// <summary>
            /// 
            /// </summary>
            public string GS1Barcode;
            /// <summary>
            /// The weight in grams
            /// </summary>
            public int weight;
            /// <summary>
            /// The Linnworks packing Type
            /// </summary>
            public string PackingType;
            /// <summary>
            /// 
            /// </summary>
            public bool IsPackdown;
            /// <summary>
            /// 
            /// </summary>
            public bool IsPrepack;

            /// <summary>
            /// The amount of times the item was picked in the last 4 weeks, averaged to pwe week..
            /// </summary>
            public double PicksPerWeek;
            /// <summary>
            /// Data related to the issues that were raised on the item in the last 4 weeks.
            /// </summary>
            public MispickStatistic MissedPicks;
            /// <summary>
            /// 
            /// </summary>
            public PostalType NewPostalType;
            /// <summary>
            /// 
            /// </summary>
            public bool IsListed;
            /// <summary>
            /// 
            /// </summary>
            public enum PostalType
            {
                /// <summary>
                /// 
                /// </summary>
                NULL = 0,
                /// <summary>
                /// 
                /// </summary>
                Letter = 1,
                /// <summary>
                /// 
                /// </summary>
                Packet = 2,
                /// <summary>
                /// 
                /// </summary>
                Courier = 3
            }
            /// <summary>
            /// 
            /// </summary>
            public int PickingMinimum;
            /// <summary>
            /// 
            /// </summary>
            public int PickingMaximum;
            /// <summary>
            /// 
            /// </summary>
            [JsonConstructor]
            public NewSkuData()
            {
                
            }
        }
    }
}
