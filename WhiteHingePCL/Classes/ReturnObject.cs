using System;
using System.Collections.Generic;

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// The return object for all API Calls
    /// </summary>
    public class ReturnObject
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime ReturnTime;
        /// <summary>
        /// Checks if the call was successful or not
        /// </summary>
        public bool Success = true;
        /// <summary>
        /// The exception message for use when the call is not sucessfull
        /// </summary>
        public string ExceptionMessage = string.Empty;
        /// <summary>
        /// The returned data for the specified call
        /// </summary>
        public object ReturnData = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        public ReturnObject(object Data)
        {
            Success = true;
            ExceptionMessage = "";
            ReturnData = Data;
            ReturnTime = DateTime.Now;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="message"></param>
        public ReturnObject(Exception ex, string message)
        {
            ReturnTime = DateTime.Now;
            Success = false;
            ExceptionMessage = message;
            ReturnData = ex;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="possibleSkus"></param>
        /// <param name="failed"></param>
        public ReturnObject(Dictionary<string, string> possibleSkus, bool failed)
        {
            ReturnTime = DateTime.Now;
            Success = failed;
            ExceptionMessage = "Pick the correct Item";
            ReturnData = possibleSkus;
        }
    }
}
