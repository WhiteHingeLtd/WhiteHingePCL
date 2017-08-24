using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteHingePCL.Classes.ReplenishmentSettings
{
    /// <summary>
    /// 
    /// </summary>
    public class ReplenishmentSettings
    {
        /// <summary>
        /// 
        /// </summary>
        public string ShortSku;
        /// <summary>
        /// 
        /// </summary>
        public bool IsPrepack;
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<int, bool> PackdownPerPacksize = new Dictionary<int, bool>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shortsku"></param>
        public ReplenishmentSettings(string shortsku)
        {
            ShortSku = shortsku;
        }
    }
}
