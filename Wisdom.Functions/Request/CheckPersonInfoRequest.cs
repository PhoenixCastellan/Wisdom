using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Wisdom.Functions.Request
{
    /// <summary>
    /// 该接口主要是根据被查询人姓名、身份号进行身份证验证
    /// </summary>
    public class CheckPersonInfoRequest:Request
    {
        public string name { get; set; }
        public string idNumber { get; set; }

        //public override string GetRequestString()
        //{
            
        //    return $"userId={HttpUtility.UrlEncode(userId)}" +
        //           $"&userPwd={HttpUtility.UrlEncode(RsaHelper.getEncString(userPwd))}" +
        //           $"&secretKey={HttpUtility.UrlEncode(secretKey)}" +
        //           $"&name={HttpUtility.UrlEncode(RsaHelper.getEncString(name))}" +
        //           $"&idNumber={HttpUtility.UrlEncode(RsaHelper.getEncString(idNumber))}";
        //}
    }
}
