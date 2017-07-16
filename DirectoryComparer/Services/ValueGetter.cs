using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DirectoryComparer.Objects;
using System.Text.RegularExpressions;
using System.Reflection;

namespace DirectoryComparer.Services
{
    public static class ValueGetter
    {
        public static string GetDescription(this Enum en) //ext method
        {
            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                var attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute),false);

                if (attrs?.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }

            return en.ToString();
        }

        public static string GetValue(this CompareResult result, string fieldName)
        {
            Regex regex = new Regex(@"[ ]{1}", RegexOptions.None);
            fieldName = regex.Replace(fieldName, @"");
            PropertyInfo prop = typeof(CompareResult).GetProperties().ToList().SingleOrDefault(p => p.Name == fieldName);
            string returnVal = string.Empty;
            if (prop != null)
            {
                object val = prop.GetValue(result, null);
                DateTime dt = DateTime.MinValue;

                if (val == null || (DateTime.TryParse(val.ToString(), out dt) && dt == DateTime.MinValue))
                    returnVal = string.Empty;
                else
                    returnVal = val.ToString();
            }
            return returnVal;
        }
    }
}
