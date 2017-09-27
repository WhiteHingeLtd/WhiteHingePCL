using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// Zone based data used for replenishment, One per Order/Item
    /// Contained in a Zone Class as a List of ZoneData
    /// </summary>
    public class ZoneData
    {
        /// <summary>
        /// The Items Location Information
        /// </summary>
        public LocationData LocationInfo;
        /// <summary>
        /// The Item's Data
        /// </summary>
        public NewWhlSku ItemData;
        /// <summary>
        /// The order data (if applicable)
        /// </summary>
        public NewOrder OrderData;
        /// <summary>
        /// The issue data (if applicable)
        /// </summary>
        public NewIssue IssueData;
        /// <summary>
        /// The amount of the item that is needed to fufil the demand amount
        /// </summary>
        public int AmountNeeded;
        /// <summary>
        /// The current ZoneDataType, based on the constructor used
        /// </summary>
        public ZoneDataType CurrentZoneDataType;

        /// <summary>
        /// The minimum amount that should be in the location
        /// </summary>
        public int MinimumInLocation = 0;
        /// <summary>
        /// The maximum amount of an item that can fit in the location
        /// </summary>
        public int MaximumInLocation = 100;
        /// <summary>
        /// Constructor for Orders (Demand)
        /// </summary>
        /// <param name="item"></param>
        /// <param name="loc"></param>
        /// <param name="order"></param>
        public ZoneData(NewWhlSku item, LocationData loc, NewOrder order)
        {
            LocationInfo = loc;
            ItemData = item;
            CurrentZoneDataType = ZoneDataType.Demand;
            OrderData = order;
            try
            {
                AmountNeeded = order.SimpleItemData.First(x => x.Key == item.Sku).Value;
            }
            catch (Exception)
            {
                AmountNeeded = 0;
            }   
        }

        /// <summary>
        /// Constructor for Issues
        /// </summary>
        /// <param name="item"></param>
        /// <param name="loc"></param>
        /// <param name="newIssue"></param>
        /// <param name="orderData"></param>
        public ZoneData(NewWhlSku item, LocationData loc,NewIssue newIssue,NewOrder orderData)
        {
            LocationInfo = loc;
            ItemData = item;
            IssueData  = newIssue;
            CurrentZoneDataType = ZoneDataType.Issue;
            AmountNeeded = newIssue.Quantity;
            OrderData = orderData;
        }
        /// <summary>
        /// Constructor for LowLevels
        /// </summary>
        /// <param name="item"></param>
        /// <param name="loc"></param>
        /// <param name="minimumAmount"></param>
        /// <param name="capableAmount"></param>
        public ZoneData(NewWhlSku item, LocationData loc,int minimumAmount,int capableAmount)
        {
            LocationInfo = loc;
            LocationInfo.Sku = item.Sku;
            ItemData = item;
            CurrentZoneDataType = ZoneDataType.LowLevel;
            MaximumInLocation = capableAmount;
            MinimumInLocation = minimumAmount;
        }
        /// <summary>
        /// This constructor is only for use by Newtonsoft
        /// </summary>
        [JsonConstructor]
        public ZoneData()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        public enum ZoneDataType
        {
            /// <summary>
            /// 
            /// </summary>
            Issue = 0,
            /// <summary>
            /// 
            /// </summary>
            Demand = 1,
            /// <summary>
            /// 
            /// </summary>
            LowLevel = 2
        }
    }
}
