using System;

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// 
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
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
        /// <summary>
        /// 
        /// </summary>
        public int OrderId;
    }
}
