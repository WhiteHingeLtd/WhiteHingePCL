using System;
using System.Collections.Generic;

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class NewOrder
    {
        /// <summary>
        /// 
        /// </summary>
        public string Filename;
        /// <summary>
        /// 
        /// </summary>
        public string OrderId;
        /// <summary>
        /// 
        /// </summary>
        public NewOrderStatus State = NewOrderStatus.DoNotUse;
        /// <summary>
        /// 
        /// </summary>
        public int ItemCount;
        /// <summary>
        /// 
        /// </summary>
        public string PostService;
        /// <summary>
        /// 
        /// </summary>
        public int StateUser;
        /// <summary>
        /// 
        /// </summary>
        public bool NeedsBox;
        /// <summary>
        /// 
        /// </summary>
        public List<NewIssue> issues = new List<NewIssue>();
        /// <summary>
        /// 
        /// </summary>
        public List<NewWhlSku> ItemData = new List<NewWhlSku>();
        /// <summary>
        /// 
        /// </summary>
        public NewPickListType PicklistType = 0;
        /// <summary>
        /// 
        /// </summary>
        public DateTime LastUpdateTime;
        /// <summary>
        /// 
        /// </summary>
        public bool SplitPrinted = false;
    }
}
