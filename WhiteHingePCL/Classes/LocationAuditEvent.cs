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
        /// The Employee's Full Name
        /// </summary>
        public string EmployeeFullName;
        /// <summary>
        /// 
        /// </summary>
        public string OriginalLocationName;
        /// <summary>
        /// 
        /// </summary>
        public string NewLocationName;
        /// <summary>
        /// 
        /// </summary>
        public int Packsize
        {
            get
            {
                int result = 0;
                int.TryParse(Sku.Substring(7), out result);
                return result;
            }
        }
        /// <summary>
        /// The total counted so far. 
        /// </summary>
        public int Total = int.MinValue;

        /// <summary>
        /// A constructor for use with the MySQL Database
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
            AuditEventId = laDict["AuditID"].ToString();
            int.TryParse(laDict["TotalAtTime"].ToString(), out Total);
        }
        /// <summary>
        /// For use with the MySQL Database and Combined with the NewEmployeeCollections
        /// </summary>
        /// <param name="queryDict"></param>
        /// <param name="newEmpColl"></param>
        public LocationAuditEvent(Dictionary<string, object> queryDict,NewEmployeeCollection newEmpColl)
        {
            Sku = queryDict["ShortSku"].ToString();
            Event = (AuditEvents) Convert.ToInt32(queryDict["AuditEvent"]);
            EmployeeId = (int)queryDict["AuditUserID"];
            OriginalLocationId = Convert.ToInt32(queryDict["LocationID"]);
            NewLocationId = -1;
            Amount = (int) queryDict["Additional"];
            EventSource = queryDict["EventSource"].ToString();
            FriendlyString = queryDict["FriendlyString"].ToString();
            DateTime.TryParse(queryDict["DateOfEvent"].ToString(), out AuditTime);
            AuditEventId = queryDict["AuditID"].ToString();
            EmployeeFullName = newEmpColl.FindUserById(EmployeeId).Fullname;
            OriginalLocationName = queryDict["LocationText"].ToString();
            int.TryParse(queryDict["TotalAtTime"].ToString(), out Total);
        }
        /// <summary>
        /// Parameterless constructor for use with Newtonsoft
        /// </summary>
        [JsonConstructor]
        public LocationAuditEvent()
        {
            
        }
    }
}
