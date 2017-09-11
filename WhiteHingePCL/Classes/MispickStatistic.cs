using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// Contains data about a sku's picking history issues when picking from the last 4 weeks.
    /// </summary>
    public class MispickStatistic
    {
        /// <summary>
        /// The amount of times the item was sent to prepack in the last 4 weeks.
        /// </summary>
        public int Prepacks;
        /// <summary>
        /// The amount of times the item was issued as cantfind in the last 4 weeks.
        /// </summary>
        public int CantFinds;
        /// <summary>
        /// The total amount of missed picks. Just Prepacks and Cantfinds added together.
        /// </summary>
        public int MissedTotal => CantFinds + Prepacks;

        /// <summary>
        /// The last time the item was issued to prepack
        /// </summary>
        public DateTime? LastPrepack;
        /// <summary>
        /// the last time the item was issued to cantfind
        /// </summary>
        public DateTime? LastCantFind;
        /// <summary>
        /// The timespan between now and the LastPrepack
        /// </summary>
        public TimeSpan? TimeSinceLastPrepack => DateTime.Now - LastPrepack;

        /// <summary>
        /// The timespan between now and the LastCantFind
        /// </summary>
        public TimeSpan? TimeSinceLastCantFind => DateTime.Now - LastCantFind;

        //Constrcutors
        /// <summary>
        /// Paramless constrcutor just here for the serialisation.
        /// </summary>
        [JsonConstructor]
        public MispickStatistic()
        {
            
        }

        private static DateTime? nullDate = new DateTime(1970, 1, 1, 0, 0, 0);

        /// <summary>
        /// Constrcutor used for providing the datas easy mode.
        /// </summary>
        /// <param name="datas"></param>
        public MispickStatistic(Dictionary<string, object> datas)
        {
            Prepacks = Convert.ToInt32(datas["Prepack"]);
            CantFinds = Convert.ToInt32(datas["CantFind"]);

            if ((DateTime?) datas["LatestCantFind"] == nullDate) LastCantFind = null; else LastCantFind = Convert.ToDateTime(datas["LatestCantFind"]);
            if ((DateTime?)datas["LatestPrepack"] == nullDate) LastPrepack = null; else LastPrepack = Convert.ToDateTime(datas["LatestPrepack"]);


        }
    }
}
