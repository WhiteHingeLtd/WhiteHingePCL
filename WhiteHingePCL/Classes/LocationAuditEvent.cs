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
    public class LocationAuditEvent
    {
        /// <summary>
        /// 
        /// </summary>
        public string AuditEventId;
        /// <summary>
        /// 
        /// </summary>
        public string Sku;
        /// <summary>
        /// 
        /// </summary>
        public int EmployeeId;
        /// <summary>
        /// 
        /// </summary>
        public AuditEvents Event;
        /// <summary>
        /// 
        /// </summary>
        public int OriginalLocationId;
        /// <summary>
        /// 
        /// </summary>
        public int NewLocationId;
        /// <summary>
        /// 
        /// </summary>
        public int Amount;
        /// <summary>
        /// 
        /// </summary>
        public DateTime AuditTime;
        /// <summary>
        /// 
        /// </summary>
        public string EventSource;
        /// <summary>
        /// 
        /// </summary>
        public string FriendlyString;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="laDict">Audit Event from the LocationAuditTable</param>
        public LocationAuditEvent(Dictionary<string, object> laDict)
        {
            Sku = laDict["ShortSku"].ToString();
            Event = (AuditEvents) Convert.ToInt32(laDict["AuditEvent"]);
            EmployeeId = (int)laDict["AuditUserID"];
            OriginalLocationId = Convert.ToInt32(laDict["LocationID"]);
            NewLocationId = -1;
            Amount = (int) laDict["Additional"];
            EventSource = laDict["EventSource"].ToString();
            FriendlyString = laDict["FriendlyString"].ToString();
            DateTime.TryParse(laDict["DateOfEvent"].ToString(), out AuditTime);
        }
    }
}
