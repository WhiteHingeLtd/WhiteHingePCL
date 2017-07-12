using System;
using System.Collections.Generic;

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Zone
    {
        /// <summary>
        /// 
        /// </summary>
        public int ZoneId;
        /// <summary>
        /// 
        /// </summary>
        public string ZoneName;

        /// <summary>
        /// 
        /// </summary>
        public int ItemCount;
        /// <summary>
        /// 
        /// </summary>
        public List<ZoneData> Items = new List<ZoneData>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="zoneName"></param>
        public Zone(string zoneName)
        {
            try
            {
                ZoneId = Convert.ToInt32(char.GetNumericValue(ZoneName[0]));
            }
            catch (Exception)
            {
                ZoneId = -1;
            }
            ItemCount = Items.Count;
            ZoneName = zoneName;
        }
    }
}
