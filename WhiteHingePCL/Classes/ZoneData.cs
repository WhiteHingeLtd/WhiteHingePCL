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
        /// <param name="item"></param>
        /// <param name="loc"></param>
        public ZoneData(NewWhlSku item, LocationData loc)
        {
            LocationInfo = loc;
            ItemData = item;
        }
    }
}
