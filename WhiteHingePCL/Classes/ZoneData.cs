using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class ZoneData
    {
        /// <summary>
        /// 
        /// </summary>
        public LocationData LocationInfo;
        /// <summary>
        /// 
        /// </summary>
        public NewWhlSku ItemData;
        /// <summary>
        /// 
        /// </summary>
        public NewOrder OrderData;
        /// <summary>
        /// 
        /// </summary>
        public NewIssue IssueData;
        /// <summary>
        /// 
        /// </summary>
        public int AmountNeeded;
        /// <summary>
        /// 
        /// </summary>
        public ZoneDataType CurrentZoneDataType;

        /// <summary>
        /// 
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
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="loc"></param>
        /// <param name="order"></param>
        public ZoneData(NewWhlSku item, LocationData loc,NewIssue order)
        {
            LocationInfo = loc;
            ItemData = item;
            IssueData  = order;
            CurrentZoneDataType = ZoneDataType.Issue;
            AmountNeeded = order.Quantity;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="loc"></param>
        /// <param name="suggestedAmount"></param>
        /// <param name="capableAmount"></param>
        public ZoneData(NewWhlSku item, LocationData loc,int suggestedAmount,int capableAmount)
        {
            LocationInfo = loc;
            ItemData = item;
            CurrentZoneDataType = ZoneDataType.LowLevel;
            
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
