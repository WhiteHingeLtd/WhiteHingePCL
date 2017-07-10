using System;

namespace WhiteHingePCL.Exceptions
{
    /// <summary>
    /// 
    /// </summary>
    public class IncorrectParametersException : Exception
    {
        /// <summary>Gets a message that describes the current exception.</summary>
        /// <returns>The error message that explains the reason for the exception, or an empty string ("").</returns>
        public override string Message { get; } = "The paramaters for this call were incorrect.";
    }
    /// <summary>
    /// 
    /// </summary>
    public class ItemNotFoundException : Exception
    {
        /// <summary>Gets a message that describes the current exception.</summary>
        /// <returns>The error message that explains the reason for the exception, or an empty string ("").</returns>
        public override string Message { get; } = "Could not find the specified item. Please try again.";
    }

    /// <summary>
    /// 
    /// </summary>
    public class WebApiInitializationException : Exception
    {
        /// <summary>Gets a message that describes the current exception.</summary>
        /// <returns>The error message that explains the reason for the exception, or an empty string ("").</returns>
        public override string Message { get; } = "The WebApi has failed to initialize. Please try again later or contact IT.";
    }
    /// <summary>
    /// 
    /// </summary>
    public class IncorrectPinException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public override string Message { get; } = "This pin is incorrect please try again";
    }
}
