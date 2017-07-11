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
        ShitsFuckedYo = 0,
        /// <summary>
        /// 
        /// </summary>
        NewLocation = 1,
        /// <summary>
        /// 
        /// </summary>
        AdjustedStock = 2,
        /// <summary>
        /// 
        /// </summary>
        RemovedLocation = 3,
        /// <summary>
        /// 
        /// </summary>
        AutoAdjustedStock = 4,
        /// <summary>
        /// 
        /// </summary>
        AutoRemovedStock = 5,
        /// <summary>
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
