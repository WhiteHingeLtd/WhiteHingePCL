using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WhiteHingePCL.Classes.ReplenishmentSettings
{
    /// <summary>
    /// 
    /// </summary>
    public class ReplenishmentLog
    {
        /// <summary>
        /// 
        /// </summary>
        public int AuditLogId;
        /// <summary>
        /// 
        /// </summary>
        public int UserId;
        /// <summary>
        /// 
        /// </summary>
        public string Sku;
        /// <summary>
        /// 
        /// </summary>
        private int dbAuditType;
        /// <summary>
        /// /
        /// </summary>
        public ReplenishmentAuditType AuditType => (ReplenishmentAuditType) dbAuditType;
        /// <summary>
        /// 
        /// </summary>
        public string NewValue;
        /// <summary>
        /// 
        /// </summary>
        [JsonConstructor]
        public ReplenishmentLog()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlData"></param>
        public ReplenishmentLog(Dictionary<string, object> sqlData)
        {
            AuditLogId = (int) sqlData["auditLogId"];
            UserId = (int) sqlData["userId"];
            Sku = sqlData["SKU"].ToString();
            dbAuditType =(int) sqlData["auditEventType"];
            NewValue = sqlData["newValue"].ToString();
        }
    }
}
