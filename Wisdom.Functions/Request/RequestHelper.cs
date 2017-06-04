using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Wisdom.Functions.Request
{
    public class RequestHelper
    {
        public static string GetRequestString<T>(T model)
        {
            var sb = new StringBuilder();
            sb.Append(GetBaseRequestString());

            Type t = model.GetType();
            PropertyInfo[] propertyList = t.GetProperties();
            foreach (PropertyInfo item in propertyList)
            {
                var value = item.GetValue(model, null).ToString();
                if (item.Name != "secretKey" && item.Name != "userId")
                {
                    value = RsaHelper.getEncString(value);
                }
                value = HttpUtility.UrlEncode(value);
                sb.AppendFormat("&{0}={1}", item.Name, value);
            }
            return sb.ToString();
        }

        public static string GetBaseRequestString()
        {
            var userId = GlobalInfo.UserId;
            var userPwd = GlobalInfo.UserPwd;
            var secretKey = RsaHelper.GetScretKey();
            return $"userId={HttpUtility.UrlEncode(userId)}" +
                   $"&userPwd={HttpUtility.UrlEncode(RsaHelper.getEncString(userPwd))}" +
                   $"&secretKey={HttpUtility.UrlEncode(secretKey)}";

        }
    }
}
