using System;

namespace LinitPro.CommonTools.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class MessageAttribute: Attribute
    {
        public string Message { get; }

        public MessageAttribute(string message)
        {
            this.Message = message;
        }
    }
}