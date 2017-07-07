using System;

namespace WhiteHingePCL.Classes
{
    /// <summary>
    /// The return object for all API Calls
    /// </summary>
    public class ReturnObject
    {
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
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="message"></param>
        public ReturnObject(Exception ex, string message)
        {
            Success = false;
            ExceptionMessage = ex.Message;
            ReturnData = ex;
        }

    }
}
