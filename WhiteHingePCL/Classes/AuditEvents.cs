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
    public enum AuditEvents
    {
        /// <summary>
        /// 
        /// </summary>
        Default = 0,
        /// <summary>
        /// Used for Adding a New Location
        /// </summary>
        NewLocation = 1,
        /// <summary>
        /// Used for changing a stock amount
        /// </summary>
        AdjustedStock = 2,
        /// <summary>
        /// Used for removing items from a location
        /// </summary>
        RemovedLocation = 3,
        /// <summary>
        /// Auto Adjusting stock, Used for Surface Picker
        /// </summary>
        AutoAdjustedStock = 4,
        /// <summary>
        /// Auto Removal of Stock, Used for Prepack
        /// </summary>
        AutoRemovedStock = 5,
        /// <summary>
        /// Used for automatically adding a location, such as for new items
        /// 
        /// </summary>
        AutoAddedLocation = 6,
        /// <summary>
        /// 
        /// </summary>
        Adjust_Add = 11,
        /// <summary>
        /// 
        /// </summary>
        Adjust_Remove = 12,
        /// <summary>
        /// 
        /// </summary>
        Adjust_Set = 13,
        /// <summary>
        /// 
        /// </summary>
        Move_From = 14,
        /// <summary>
        /// 
        /// </summary>
        Move_To = 15,
    }
}
