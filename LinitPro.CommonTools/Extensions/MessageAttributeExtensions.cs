using System;
using System.Linq;
using System.Reflection;
using LinitPro.CommonTools.Attributes;

namespace LinitPro.CommonTools.Extensions
{
    public static class MessageAttributeExtensions
    {
        public static string GetMessage(this object item)
        {
            var attributes = item.GetType().GetMember(item.ToString()).FirstOrDefault()
                ?.GetCustomAttributes(typeof(MessageAttribute), false);
            return attributes.Any() ? ((MessageAttribute)attributes[0]).Message : "";
        }
        
        public static string GetMessage(this MemberInfo item)
        {
            var _attributes = item.GetCustomAttributes(typeof(MessageAttribute), false);
            return _attributes.Any() ? ((MessageAttribute)_attributes[0]).Message : "";
        }
    }
}