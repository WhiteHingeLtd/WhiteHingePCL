using System;
using System.Collections.Generic;
using System.Linq;

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class NewOrder
    {
        /// <summary>
        /// The filename on the server (or Database name when moved to SQL)
        /// </summary>
        public string Filename;
        /// <summary>
        /// The Numeric OrderId;
        /// </summary>
        public string OrderId;
        /// <summary>
        /// The Guid used by Linnworks for tracking orders
        /// </summary>
        public Guid LinnworksOrderGuid;
        /// <summary>
        /// The current OrderStatus, defaults to DoNotUse
        /// </summary>
        public NewOrderStatus State = NewOrderStatus.DoNotUse;
        /// <summary>
        /// 
        /// </summary>
        public int ItemCount => ItemData.Count;

        /// <summary>
        /// The Postal Service used for this order
        /// </summary>
        public string PostService;
        /// <summary>
        /// 
        /// </summary>
        public int StateUser;
        /// <summary>
        /// 
        /// </summary>
        public bool NeedsBox;
        /// <summary>
        /// A list of issues
        /// </summary>
        public List<NewIssue> Issues = new List<NewIssue>();
        /// <summary>
        /// A Dictionary of items and respective quantities in this order
        /// </summary>
        public Dictionary<NewWhlSku,int> ItemData = new Dictionary<NewWhlSku, int>();
        /// <summary>
        /// The PickList type
        /// </summary>
        public NewPickListType PicklistType = 0;
        /// <summary>
        /// When this order was last Updated
        /// </summary>
        public DateTime LastUpdateTime;
        /// <summary>
        /// Determines if this a split order
        /// </summary>
        public bool SplitPrinted = false;
        /// <summary>
        /// Checks the ItemData for stock in the picking locations
        /// </summary>
        public bool IsPickable
        {
            get
            {
                return ItemData.All(kvp => kvp.Key.HasRequiredStockInPrimaryLocation(kvp.Value));
            }
        }
    }
}
