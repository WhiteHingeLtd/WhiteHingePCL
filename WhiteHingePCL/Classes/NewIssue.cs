using System;
using System.Text;
using System.Threading.Tasks;

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class NewIssue
    {

        /// <summary>
        /// 
        /// </summary>
        public NewOrderStatus IssueType = NewOrderStatus.DoNotUse;
        /// <summary>
        /// 
        /// </summary>
        public string IssueSku;
        /// <summary>
        /// 
        /// </summary>
        public bool Resolved = false;
        /// <summary>
        /// 
        /// </summary>
        public int ReportingUser = 0;

        /// <summary>
        /// 
        /// </summary>
        public DateTime TimeReported;

        /// <summary>
        /// 
        /// </summary>
        public string Reason = "";
        /// <summary>
        /// 
        /// </summary>
        public int Quantity = 1;

    }
}
