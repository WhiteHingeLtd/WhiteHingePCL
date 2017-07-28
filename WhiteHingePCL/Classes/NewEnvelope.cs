using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class NewEnvelope
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonConstructor]
        public NewEnvelope()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        public string envCode;

        /// <summary>
        /// 
        /// </summary>
        public string envName;

        /// <summary>
        /// 
        /// </summary>
        public int envWeight;

        /// <summary>
        /// 
        /// </summary>
        public string envSize;

        /// <summary>
        /// 
        /// </summary>
        public string envFrom;

        /// <summary>
        /// 
        /// </summary>
        public int envBoxQuan;

        /// <summary>
        /// 
        /// </summary>
        public float envBoxNet;

        /// <summary>
        /// 
        /// </summary>
        public float envIndCost;

        /// <summary>
        /// 
        /// </summary>
        public bool NeedsBox;

        /// <summary>
        /// 
        /// </summary>
        public bool isHidden;

        /// <summary>
        /// 
        /// </summary>
        public string envNewName;
    }
}
